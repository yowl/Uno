#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaElement : global::Windows.UI.Xaml.FrameworkElement
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double Volume
		{
			get
			{
				return (double)this.GetValue(VolumeProperty);
			}
			set
			{
				this.SetValue(VolumeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Stereo3DVideoRenderMode Stereo3DVideoRenderMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Stereo3DVideoRenderMode)this.GetValue(Stereo3DVideoRenderModeProperty);
			}
			set
			{
				this.SetValue(Stereo3DVideoRenderModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Stereo3DVideoPackingMode Stereo3DVideoPackingMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Stereo3DVideoPackingMode)this.GetValue(Stereo3DVideoPackingModeProperty);
			}
			set
			{
				this.SetValue(Stereo3DVideoPackingModeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Uri Source
		{
			get
			{
				return (global::System.Uri)this.GetValue(SourceProperty);
			}
			set
			{
				this.SetValue(SourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool RealTimePlayback
		{
			get
			{
				return (bool)this.GetValue(RealTimePlaybackProperty);
			}
			set
			{
				this.SetValue(RealTimePlaybackProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Protection.MediaProtectionManager ProtectionManager
		{
			get
			{
				return (global::Windows.Media.Protection.MediaProtectionManager)this.GetValue(ProtectionManagerProperty);
			}
			set
			{
				this.SetValue(ProtectionManagerProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.ImageSource PosterSource
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.ImageSource)this.GetValue(PosterSourceProperty);
			}
			set
			{
				this.SetValue(PosterSourceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.TimeSpan Position
		{
			get
			{
				return (global::System.TimeSpan)this.GetValue(PositionProperty);
			}
			set
			{
				this.SetValue(PositionProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double PlaybackRate
		{
			get
			{
				return (double)this.GetValue(PlaybackRateProperty);
			}
			set
			{
				this.SetValue(PlaybackRateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AutoPlay
		{
			get
			{
				return (bool)this.GetValue(AutoPlayProperty);
			}
			set
			{
				this.SetValue(AutoPlayProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int? AudioStreamIndex
		{
			get
			{
				return (int?)this.GetValue(AudioStreamIndexProperty);
			}
			set
			{
				this.SetValue(AudioStreamIndexProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsMuted
		{
			get
			{
				return (bool)this.GetValue(IsMutedProperty);
			}
			set
			{
				this.SetValue(IsMutedProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.AudioDeviceType AudioDeviceType
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.AudioDeviceType)this.GetValue(AudioDeviceTypeProperty);
			}
			set
			{
				this.SetValue(AudioDeviceTypeProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.AudioCategory AudioCategory
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.AudioCategory)this.GetValue(AudioCategoryProperty);
			}
			set
			{
				this.SetValue(AudioCategoryProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double DefaultPlaybackRate
		{
			get
			{
				return (double)this.GetValue(DefaultPlaybackRateProperty);
			}
			set
			{
				this.SetValue(DefaultPlaybackRateProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsLooping
		{
			get
			{
				return (bool)this.GetValue(IsLoopingProperty);
			}
			set
			{
				this.SetValue(IsLoopingProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double Balance
		{
			get
			{
				return (double)this.GetValue(BalanceProperty);
			}
			set
			{
				this.SetValue(BalanceProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double DownloadProgressOffset
		{
			get
			{
				return (double)this.GetValue(DownloadProgressOffsetProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsAudioOnly
		{
			get
			{
				return (bool)this.GetValue(IsAudioOnlyProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsStereo3DVideo
		{
			get
			{
				return (bool)this.GetValue(IsStereo3DVideoProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.TimelineMarkerCollection Markers
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimelineMarkerCollection MediaElement.Markers is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Duration NaturalDuration
		{
			get
			{
				return (global::Windows.UI.Xaml.Duration)this.GetValue(NaturalDurationProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int NaturalVideoHeight
		{
			get
			{
				return (int)this.GetValue(NaturalVideoHeightProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int NaturalVideoWidth
		{
			get
			{
				return (int)this.GetValue(NaturalVideoWidthProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.PlayTo.PlayToSource PlayToSource
		{
			get
			{
				return (global::Windows.Media.PlayTo.PlayToSource)this.GetValue(PlayToSourceProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Stereo3DVideoPackingMode ActualStereo3DVideoPackingMode
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Stereo3DVideoPackingMode)this.GetValue(ActualStereo3DVideoPackingModeProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int AspectRatioHeight
		{
			get
			{
				return (int)this.GetValue(AspectRatioHeightProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int AspectRatioWidth
		{
			get
			{
				return (int)this.GetValue(AspectRatioWidthProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  int AudioStreamCount
		{
			get
			{
				return (int)this.GetValue(AudioStreamCountProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double BufferingProgress
		{
			get
			{
				return (double)this.GetValue(BufferingProgressProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanPause
		{
			get
			{
				return (bool)this.GetValue(CanPauseProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool CanSeek
		{
			get
			{
				return (bool)this.GetValue(CanSeekProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.MediaElementState CurrentState
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.MediaElementState)this.GetValue(CurrentStateProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  double DownloadProgress
		{
			get
			{
				return (double)this.GetValue(DownloadProgressProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Stretch Stretch
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Stretch)this.GetValue(StretchProperty);
			}
			set
			{
				this.SetValue(StretchProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::System.Uri PlayToPreferredSourceUri
		{
			get
			{
				return (global::System.Uri)this.GetValue(PlayToPreferredSourceUriProperty);
			}
			set
			{
				this.SetValue(PlayToPreferredSourceUriProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool IsFullWindow
		{
			get
			{
				return (bool)this.GetValue(IsFullWindowProperty);
			}
			set
			{
				this.SetValue(IsFullWindowProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  bool AreTransportControlsEnabled
		{
			get
			{
				return (bool)this.GetValue(AreTransportControlsEnabledProperty);
			}
			set
			{
				this.SetValue(AreTransportControlsEnabledProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Controls.MediaTransportControls TransportControls
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaTransportControls MediaElement.TransportControls is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "MediaTransportControls MediaElement.TransportControls");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DownloadProgressOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"DownloadProgressOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty SourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Source", typeof(global::System.Uri), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::System.Uri)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty Stereo3DVideoPackingModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Stereo3DVideoPackingMode", typeof(global::Windows.UI.Xaml.Media.Stereo3DVideoPackingMode), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Stereo3DVideoPackingMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty Stereo3DVideoRenderModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Stereo3DVideoRenderMode", typeof(global::Windows.UI.Xaml.Media.Stereo3DVideoRenderMode), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Stereo3DVideoRenderMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ActualStereo3DVideoPackingModeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ActualStereo3DVideoPackingMode", typeof(global::Windows.UI.Xaml.Media.Stereo3DVideoPackingMode), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Stereo3DVideoPackingMode)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AspectRatioHeightProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AspectRatioHeight", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AspectRatioWidthProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AspectRatioWidth", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AudioCategoryProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AudioCategory", typeof(global::Windows.UI.Xaml.Media.AudioCategory), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.AudioCategory)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AudioDeviceTypeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AudioDeviceType", typeof(global::Windows.UI.Xaml.Media.AudioDeviceType), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.AudioDeviceType)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AudioStreamCountProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AudioStreamCount", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AudioStreamIndexProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AudioStreamIndex", typeof(int?), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(int?)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AutoPlayProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AutoPlay", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty BalanceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Balance", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty BufferingProgressProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"BufferingProgress", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CanPauseProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CanPause", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CanSeekProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CanSeek", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty CurrentStateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"CurrentState", typeof(global::Windows.UI.Xaml.Media.MediaElementState), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.MediaElementState)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DefaultPlaybackRateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"DefaultPlaybackRate", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty VolumeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Volume", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty DownloadProgressProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"DownloadProgress", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsAudioOnlyProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsAudioOnly", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsLoopingProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsLooping", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsMutedProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsMuted", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsStereo3DVideoProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsStereo3DVideo", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty NaturalDurationProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"NaturalDuration", typeof(global::Windows.UI.Xaml.Duration), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Duration)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty NaturalVideoHeightProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"NaturalVideoHeight", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty NaturalVideoWidthProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"NaturalVideoWidth", typeof(int), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(int)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PlayToSourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PlayToSource", typeof(global::Windows.Media.PlayTo.PlayToSource), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::Windows.Media.PlayTo.PlayToSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PlaybackRateProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PlaybackRate", typeof(double), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PositionProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Position", typeof(global::System.TimeSpan), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::System.TimeSpan)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PosterSourceProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PosterSource", typeof(global::Windows.UI.Xaml.Media.ImageSource), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.ImageSource)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty ProtectionManagerProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"ProtectionManager", typeof(global::Windows.Media.Protection.MediaProtectionManager), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::Windows.Media.Protection.MediaProtectionManager)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty RealTimePlaybackProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"RealTimePlayback", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty IsFullWindowProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"IsFullWindow", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty PlayToPreferredSourceUriProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"PlayToPreferredSourceUri", typeof(global::System.Uri), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::System.Uri)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StretchProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Stretch", typeof(global::Windows.UI.Xaml.Media.Stretch), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Stretch)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty AreTransportControlsEnabledProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"AreTransportControlsEnabled", typeof(bool), 
			typeof(global::Windows.UI.Xaml.Controls.MediaElement), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public MediaElement() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "MediaElement.MediaElement()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.MediaElement()
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PosterSource.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PosterSource.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Source.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Source.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsMuted.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsMuted.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsAudioOnly.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AutoPlay.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AutoPlay.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Volume.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Volume.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Balance.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Balance.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.NaturalVideoHeight.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.NaturalVideoWidth.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.NaturalDuration.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Position.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Position.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.DownloadProgress.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.BufferingProgress.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.DownloadProgressOffset.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.CurrentState.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Markers.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.CanSeek.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.CanPause.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AudioStreamCount.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AudioStreamIndex.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AudioStreamIndex.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PlaybackRate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PlaybackRate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsLooping.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsLooping.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PlayToSource.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.DefaultPlaybackRate.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.DefaultPlaybackRate.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AspectRatioWidth.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AspectRatioHeight.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.RealTimePlayback.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.RealTimePlayback.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AudioCategory.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AudioCategory.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AudioDeviceType.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AudioDeviceType.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.ProtectionManager.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.ProtectionManager.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Stereo3DVideoPackingMode.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Stereo3DVideoPackingMode.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Stereo3DVideoRenderMode.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Stereo3DVideoRenderMode.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsStereo3DVideo.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.MediaOpened.add
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.MediaOpened.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.MediaEnded.add
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.MediaEnded.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.MediaFailed.add
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.MediaFailed.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.DownloadProgressChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.DownloadProgressChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.BufferingProgressChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.BufferingProgressChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.CurrentStateChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.CurrentStateChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.MarkerReached.add
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.MarkerReached.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.RateChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.RateChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.VolumeChanged.add
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.VolumeChanged.remove
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.SeekCompleted.add
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.SeekCompleted.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Stop()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "void MediaElement.Stop()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Play()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "void MediaElement.Play()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void Pause()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "void MediaElement.Pause()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.MediaCanPlayResponse CanPlayType( string type)
		{
			throw new global::System.NotImplementedException("The member MediaCanPlayResponse MediaElement.CanPlayType(string type) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetSource( global::Windows.Storage.Streams.IRandomAccessStream stream,  string mimeType)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "void MediaElement.SetSource(IRandomAccessStream stream, string mimeType)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  string GetAudioStreamLanguage( int? index)
		{
			throw new global::System.NotImplementedException("The member string MediaElement.GetAudioStreamLanguage(int? index) is not implemented in Uno.");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void AddAudioEffect( string effectID,  bool effectOptional,  global::Windows.Foundation.Collections.IPropertySet effectConfiguration)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "void MediaElement.AddAudioEffect(string effectID, bool effectOptional, IPropertySet effectConfiguration)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void AddVideoEffect( string effectID,  bool effectOptional,  global::Windows.Foundation.Collections.IPropertySet effectConfiguration)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "void MediaElement.AddVideoEffect(string effectID, bool effectOptional, IPropertySet effectConfiguration)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void RemoveAllEffects()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "void MediaElement.RemoveAllEffects()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.ActualStereo3DVideoPackingMode.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AreTransportControlsEnabled.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AreTransportControlsEnabled.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Stretch.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Stretch.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsFullWindow.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsFullWindow.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetMediaStreamSource( global::Windows.Media.Core.IMediaSource source)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "void MediaElement.SetMediaStreamSource(IMediaSource source)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PlayToPreferredSourceUri.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PlayToPreferredSourceUri.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.TransportControls.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.TransportControls.set
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PartialMediaFailureDetected.add
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PartialMediaFailureDetected.remove
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  void SetPlaybackSource( global::Windows.Media.Playback.IMediaPlaybackSource source)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "void MediaElement.SetPlaybackSource(IMediaPlaybackSource source)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.Media.Casting.CastingSource GetAsCastingSource()
		{
			throw new global::System.NotImplementedException("The member CastingSource MediaElement.GetAsCastingSource() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AreTransportControlsEnabledProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.StretchProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsFullWindowProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PlayToPreferredSourceUriProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PosterSourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.SourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsMutedProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsAudioOnlyProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AutoPlayProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.VolumeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.BalanceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.NaturalVideoHeightProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.NaturalVideoWidthProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.NaturalDurationProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PositionProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.DownloadProgressProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.BufferingProgressProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.DownloadProgressOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.CurrentStateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.CanSeekProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.CanPauseProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AudioStreamCountProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AudioStreamIndexProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PlaybackRateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsLoopingProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.PlayToSourceProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.DefaultPlaybackRateProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AspectRatioWidthProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AspectRatioHeightProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.RealTimePlaybackProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AudioCategoryProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.AudioDeviceTypeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.ProtectionManagerProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Stereo3DVideoPackingModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.Stereo3DVideoRenderModeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.IsStereo3DVideoProperty.get
		// Forced skipping of method Windows.UI.Xaml.Controls.MediaElement.ActualStereo3DVideoPackingModeProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.RoutedEventHandler BufferingProgressChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.BufferingProgressChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.BufferingProgressChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.RoutedEventHandler CurrentStateChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.CurrentStateChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.CurrentStateChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.RoutedEventHandler DownloadProgressChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.DownloadProgressChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.DownloadProgressChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Media.TimelineMarkerRoutedEventHandler MarkerReached
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event TimelineMarkerRoutedEventHandler MediaElement.MarkerReached");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event TimelineMarkerRoutedEventHandler MediaElement.MarkerReached");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.RoutedEventHandler MediaEnded
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.MediaEnded");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.MediaEnded");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.ExceptionRoutedEventHandler MediaFailed
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event ExceptionRoutedEventHandler MediaElement.MediaFailed");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event ExceptionRoutedEventHandler MediaElement.MediaFailed");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.RoutedEventHandler MediaOpened
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.MediaOpened");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.MediaOpened");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.Media.RateChangedRoutedEventHandler RateChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RateChangedRoutedEventHandler MediaElement.RateChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RateChangedRoutedEventHandler MediaElement.RateChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.RoutedEventHandler SeekCompleted
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.SeekCompleted");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.SeekCompleted");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.UI.Xaml.RoutedEventHandler VolumeChanged
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.VolumeChanged");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event RoutedEventHandler MediaElement.VolumeChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.MediaElement, global::Windows.UI.Xaml.Media.PartialMediaFailureDetectedEventArgs> PartialMediaFailureDetected
		{
			[global::Uno.NotImplemented]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event TypedEventHandler<MediaElement, PartialMediaFailureDetectedEventArgs> MediaElement.PartialMediaFailureDetected");
			}
			[global::Uno.NotImplemented]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Controls.MediaElement", "event TypedEventHandler<MediaElement, PartialMediaFailureDetectedEventArgs> MediaElement.PartialMediaFailureDetected");
			}
		}
		#endif
	}
}
