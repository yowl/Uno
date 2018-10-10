using System;
using System.ComponentModel;
using System.Globalization;
using Windows.Media.Core;

namespace Windows.Media.Playback
{
	public partial class MediaPlaybackSourceConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) ||
				 sourceType == typeof(Uri) ||
				 base.CanConvertFrom(context, sourceType);
		}
		public override bool CanConvertTo(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(MediaSource) || sourceType == typeof(MediaPlaybackItem) || base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string stringValue && !string.IsNullOrWhiteSpace(stringValue))
			{
				return MediaPlaybackItem.FindFromMediaSource(MediaSource.CreateFromUri(new Uri(stringValue)));
			}

			if (value is Uri uriValue)
			{
				return MediaPlaybackItem.FindFromMediaSource(MediaSource.CreateFromUri(uriValue));
			}

			return base.ConvertFrom(context, culture, value);
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType != null && value is MediaPlaybackItem item)
			{
				if (destinationType == typeof(string))
				{
					return item.Source?.Uri.ToString();
				}

				if (destinationType == typeof(Uri))
				{
					return item.Source?.Uri;
				}
			}

			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
