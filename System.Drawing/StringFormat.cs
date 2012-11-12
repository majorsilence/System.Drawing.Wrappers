using System;

namespace System.Drawing
{
	public class StringFormat
	{
		public StringFormat ()
		{
			throw new NotImplementedException();
		}

		public StringFormat(StringFormat sf)
		{
			throw new NotImplementedException();
		}

		public StringFormat(StringFormatFlags sff)
		{
			FormatFlags = sff;
			throw new NotImplementedException();
		}

		public StringFormatFlags FormatFlags {get; set; }

		public StringAlignment Alignment { get; set; }

	}
}

