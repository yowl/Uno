#if __ANDROID__ || __IOS__

using System;
using System.Linq;
using System.Timers;
using Uno.Disposables;
using System.Windows.Input;
using Uno.Extensions;
using Uno.Logging;
using Uno.UI.Common;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
	public partial class MediaTransportControls : Control
	{
		private Windows.Media.Playback.MediaPlayer _mediaPlayer;
		private bool _isScrubbing = false;
		
		private ICommand _selectAudioTrackCommand;
		private ICommand _selectSubtitleTrackCommand;
		
		private SerialDisposable _subscriptions = new SerialDisposable();
		
		internal void SetMediaPlayer(Windows.Media.Playback.MediaPlayer mediaPlayer)
		{
			UnbindMediaPlayer();

			_mediaPlayer = mediaPlayer;

			if (_playPauseButton != null)
			{
				BindMediaPlayer();
			}
		}

		private void BindMediaPlayer()
		{
			_subscriptions.Disposable = null;

			_selectAudioTrackCommand = new DelegateCommand<AudioTrack>(SelectAudioTrack);
			_selectSubtitleTrackCommand = new DelegateCommand<TimedMetadataTrack>(SelectSubtitleTrack);

			_mediaPlayer.PlaybackSession.PlaybackStateChanged += OnPlaybackStateChanged;
			_mediaPlayer.PlaybackSession.BufferingProgressChanged += OnBufferingProgressChanged;
			_mediaPlayer.PlaybackSession.NaturalDurationChanged += OnNaturalDurationChanged;
			_mediaPlayer.PlaybackSession.PositionChanged += OnPositionChanged;
			_mediaPlayer.SourceChanged += OnSourceChanged;

			_playPauseButton.Maybe(p => p.Click += PlayPause);
			_playPauseButtonOnLeft.Maybe(p => p.Click += PlayPause);
			_audioMuteButton.Maybe(p => p.Click += ToggleMute);
			_volumeSlider.Maybe(p => p.ValueChanged += OnVolumeChanged);
			_stopButton.Maybe(p => p.Click += Stop);
			_skipForwardButton.Maybe(p => p.Click += SkipForward);
			_skipBackwardButton.Maybe(p => p.Click += SkipBackward);

			_subscriptions.Disposable = AttachThumbEventHandlers(_progressSlider);
		}

		private void OnSliderTemplateChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
		{
			_subscriptions.Disposable = null;

			if (_mediaPlayer != null)
			{
				_subscriptions.Disposable = AttachThumbEventHandlers(_progressSlider);
			}
		}

		private void UnbindMediaPlayer()
		{
			try
			{
				_subscriptions.Disposable = null;

				if (_mediaPlayer != null)
				{
					_mediaPlayer.PlaybackSession.PlaybackStateChanged -= OnPlaybackStateChanged;
					_mediaPlayer.PlaybackSession.BufferingProgressChanged -= OnBufferingProgressChanged;
					_mediaPlayer.PlaybackSession.NaturalDurationChanged -= OnNaturalDurationChanged;
					_mediaPlayer.PlaybackSession.PositionChanged -= OnPositionChanged;
				}

				_playPauseButton.Maybe(p => p.Click -= PlayPause);
				_playPauseButtonOnLeft.Maybe(p => p.Click -= PlayPause);
				_audioMuteButton.Maybe(p => p.Click -= ToggleMute);
				_volumeSlider.Maybe(p => p.ValueChanged -= OnVolumeChanged);
				_stopButton.Maybe(p => p.Click -= Stop);
				_skipForwardButton.Maybe(p => p.Click -= SkipForward);
				_skipBackwardButton.Maybe(p => p.Click -= SkipBackward);
			}
			catch (Exception ex)
			{
				this.Log().ErrorIfEnabled(() => $"Unable to unbind MediaTransportControls properly: {ex.Message}", ex);
			}
		}

		private void OnPlaybackStateChanged(MediaPlaybackSession sender, object args)
		{
			var state = (MediaPlaybackState)args;
			
			switch (state)
			{
				case MediaPlaybackState.Opening:
				case MediaPlaybackState.Paused:
				case MediaPlaybackState.None:
					CancelControlsVisibilityTimer();
					VisualStateManager.GoToState(this, "PlayState", false);
					VisualStateManager.GoToState(this, "Normal", false);
					break;
				case MediaPlaybackState.Playing:
					ResetControlsVisibilityTimer();
					VisualStateManager.GoToState(this, "PauseState", false);
					VisualStateManager.GoToState(this, "Normal", false);
					break;
				case MediaPlaybackState.Buffering:
					VisualStateManager.GoToState(this, "Buffering", false);
					break;
			}
		}

		private void OnBufferingProgressChanged(MediaPlaybackSession sender, object args)
		{

			Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
			{
				if (_downloadProgressIndicator != null)
				{
					_downloadProgressIndicator.Value = (double)args;
				}
			});
		}

		private void OnNaturalDurationChanged(MediaPlaybackSession sender, object args)
		{
			Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
			{
				var duration = args as TimeSpan? ?? TimeSpan.Zero;
				_progressSlider.Minimum = 0;
				_progressSlider.Maximum = duration.TotalSeconds;

				if (_mediaPlayer.PlaybackSession.PlaybackState != MediaPlaybackState.Playing && _mediaPlayer.PlaybackSession.PlaybackState != MediaPlaybackState.Paused)
				{
					_timeRemainingElement.Text = $"{duration.TotalHours:0}:{duration.Minutes:00}:{duration.Seconds:00}";
				}
			});
		}

		private void OnPositionChanged(MediaPlaybackSession sender, object args)
		{
			Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
			{
				var elapsed = args as TimeSpan? ?? TimeSpan.Zero;
				_timeElapsedElement.Text = $"{elapsed.TotalHours:0}:{elapsed.Minutes:00}:{elapsed.Seconds:00}";
				_progressSlider.Value = elapsed.TotalSeconds;

				var remaining = _mediaPlayer.PlaybackSession.NaturalDuration - elapsed;
				_timeRemainingElement.Text = $"{remaining.TotalHours:0}:{remaining.Minutes:00}:{remaining.Seconds:00}";
			});
		}

		private void OnSourceChanged(Windows.Media.Playback.MediaPlayer sender, object args)
		{
			UpdateAudioTracks();
			UpdateSubtitleTracks();
		}

		private void UpdateSubtitleTracks()
		{
			Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
			{
				_ccSelectionButton.Visibility = Visibility.Collapsed;

				if (_ccSelectionButton.Flyout is MenuFlyout ccFlyout)
				{
					ccFlyout.Items.Clear();
				}

				if (_mediaPlayer.InnerSource.TimedMetadataTracks.Count > 0)
				{
					_ccSelectionButton.Flyout = new MenuFlyout();
					var hasSelection = false;

					for (int index = 0; index < _mediaPlayer.InnerSource.TimedMetadataTracks.Count; index++)
					{
						var subtitle = _mediaPlayer.InnerSource.TimedMetadataTracks[index];
						var isSelected = _mediaPlayer.InnerSource.TimedMetadataTracks.GetPresentationMode((uint)index) == TimedMetadataTrackPresentationMode.PlatformPresented;
						hasSelection = hasSelection || isSelected;

						((MenuFlyout)_ccSelectionButton.Flyout).Items.Add(new MenuFlyoutItem()
						{
							Text = isSelected ? $"{subtitle.Label} (On)" : subtitle.Label,
							Command = _selectSubtitleTrackCommand,
							CommandParameter = subtitle
						});
					}

					if (hasSelection)
					{
						((MenuFlyout)_ccSelectionButton.Flyout).Items.Add(new MenuFlyoutItem()
						{
							Text = "Off",
							Command = _selectSubtitleTrackCommand,
							CommandParameter = null
						});
					}

					_ccSelectionButton.Visibility = Visibility.Visible;
				}
			});
		}

		private void UpdateAudioTracks()
		{
			Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
			{
				_audioTracksSelectionButton.Visibility = Visibility.Collapsed;

				if (_audioTracksSelectionButton.Flyout is MenuFlyout audioFlyout)
				{
					audioFlyout.Items.Clear();
				}

				if (_mediaPlayer.InnerSource.AudioTracks.Count > 1)
				{
					var flyoutItems = _mediaPlayer.InnerSource.AudioTracks
						.Select((audio, index) => new MenuFlyoutItem()
						{
							Text = index == _mediaPlayer.InnerSource.AudioTracks.SelectedIndex ? $"{audio.Label} (On)" : audio.Label,
							Command = _selectAudioTrackCommand,
							CommandParameter = audio
						});

					_audioTracksSelectionButton.Flyout = new MenuFlyout();

					((MenuFlyout)_audioTracksSelectionButton.Flyout).Items.AddRange(flyoutItems);

					_audioTracksSelectionButton.Visibility = Visibility.Visible;
				}
			});
		}

		private void SelectAudioTrack(AudioTrack track)
		{
			_mediaPlayer.InnerSource.AudioTracks.SelectedIndex = _mediaPlayer.InnerSource.AudioTracks.IndexOf(track);
			UpdateAudioTracks();
		}

		private void SelectSubtitleTrack(TimedMetadataTrack track)
		{
			foreach(var sub in _mediaPlayer.InnerSource.TimedMetadataTracks)
			{
				_mediaPlayer.InnerSource.TimedMetadataTracks.SetPresentationMode(
					(uint)_mediaPlayer.InnerSource.TimedMetadataTracks.IndexOf(sub),
					sub.Equals(track) ? TimedMetadataTrackPresentationMode.PlatformPresented : TimedMetadataTrackPresentationMode.Disabled);
			}

			UpdateSubtitleTracks();
		}

		private void PlayPause(object sender, RoutedEventArgs e)
		{
			if (_mediaPlayer.PlaybackSession.PlaybackState == MediaPlaybackState.Buffering || _mediaPlayer.PlaybackSession.PlaybackState == MediaPlaybackState.Playing)
			{
				_mediaPlayer.Pause();
			}
			else
			{
				_mediaPlayer.Play();
			}
		}

		private void Stop(object sender, RoutedEventArgs e)
		{
			_mediaPlayer.Stop();
		}

		private void SkipBackward(object sender, RoutedEventArgs e)
		{
			_mediaPlayer.PlaybackSession.Position = _mediaPlayer.PlaybackSession.Position - TimeSpan.FromSeconds(10);
		}

		private void SkipForward(object sender, RoutedEventArgs e)
		{
			_mediaPlayer.PlaybackSession.Position = _mediaPlayer.PlaybackSession.Position + TimeSpan.FromSeconds(30);
		}

		private void OnVolumeChanged(object sender, RangeBaseValueChangedEventArgs e)
		{
			_mediaPlayer.Volume = e.NewValue;
			VisualStateManager.GoToState(this, _mediaPlayer.Volume == 0 ? "MuteState" : "VolumeState", false);
			ResetControlsVisibilityTimer();
		}

		private void ToggleMute(object sender, RoutedEventArgs e)
		{
			_mediaPlayer.IsMuted = !_mediaPlayer.IsMuted;
			VisualStateManager.GoToState(this, _mediaPlayer.IsMuted ? "MuteState" : "VolumeState", false);
			ResetControlsVisibilityTimer();
		}

		private IDisposable AttachThumbEventHandlers(Slider slider)
		{
			var thumb = slider.GetTemplateChild(HorizontalThumbName) as Thumb;

			if (thumb != null)
			{
				thumb.DragStarted += ThumbOnDragStarted;
				thumb.DragCompleted += ThumbOnDragCompleted;

				return Disposable.Create(() =>
				{
					thumb.DragStarted -= ThumbOnDragStarted;
					thumb.DragCompleted -= ThumbOnDragCompleted;
				});
			}

			return Disposable.Empty;
		}

		private void ThumbOnDragCompleted(object sender, DragCompletedEventArgs dragCompletedEventArgs)
		{
			if (double.IsNaN(_progressSlider.Value))
			{
				return;
			}

			if (_mediaPlayer != null)
			{
				_mediaPlayer.PlaybackSession.Position = TimeSpan.FromSeconds(_progressSlider.Value);

				if (_wasPlaying)
				{
					_mediaPlayer.Play();
				}
			}

			_isScrubbing = false;
		}

		private void ThumbOnDragStarted(object sender, DragStartedEventArgs dragStartedEventArgs)
		{
			if (_mediaPlayer != null && !_isScrubbing)
			{
				_wasPlaying = _mediaPlayer.PlaybackSession.PlaybackState == MediaPlaybackState.Buffering || _mediaPlayer.PlaybackSession.PlaybackState == MediaPlaybackState.Playing;
				_mediaPlayer.Pause();

				_isScrubbing = true;
			}
		}
	}
}
#endif
