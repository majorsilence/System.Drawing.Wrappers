using System;

namespace System.Drawing.Imaging
{
	public class EncoderParameter : IDisposable
	{
		private byte value;
		private Encoder encode;

		public EncoderParameter ()
		{
		}

		public EncoderParameter (Encoder encoder, byte value)
		{
			this.value = value;
			this.encode = encoder;
			throw new NotImplementedException();
		}

		public EncoderParameter (Encoder encoder, long value)
		{

			this.encode = encoder;
			throw new NotImplementedException();
		}


		public void Dispose()
		{
		}

	}
}

