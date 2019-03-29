﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Windows.ApplicationModel.DataTransfer
{
	public partial class DataPackage
	{
		internal string Text { get; private set; }

#if !(NET461 || __MACOS__)
		public void SetText(string text)
		{
			if (text == null)
			{
				throw new ArgumentNullException("Text can't be null");
			}

			this.Text = text;
		}
#endif
	}
}
