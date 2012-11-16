using System;

namespace System.Drawing
{
	public class StringFormat : IDisposable
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

		public StringFormatFlags FormatFlags 
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public StringAlignment Alignment 
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}


		public StringAlignment LineAlignment 
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public StringTrimming Trimming
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}


		public void Dispose()
		{
		}

	}
}

