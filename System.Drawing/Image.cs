namespace System.Drawing
{
    using System;
#if NETFX_CORE
    using global::Windows.Foundation;
#endif

    public abstract class Image : IDisposable
    {
        public abstract int Width { get; }
        public abstract int Height { get; }

        public Size Size
        {
            get { return new Size(Width, Height); }
        }

        #region IDisposable Members

        public void Dispose()
        {
        }


		public void Save(System.IO.Stream stream, Imaging.ImageCodecInfo info, Imaging.EncoderParameters e)
		{
			throw new NotImplementedException();
		}

		public void Save(string filename)
		{
			throw new NotImplementedException();
		}

        #endregion
    }
}