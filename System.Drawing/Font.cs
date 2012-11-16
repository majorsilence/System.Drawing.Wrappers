namespace System.Drawing
{
    using System;
#if NETFX_CORE
    using global::Windows.UI.Text;
    using global::Windows.UI.Xaml.Media;
#endif

    public class Font : IDisposable
    {
        public FontFamily FontFamily { get; set; }
        public int Size { get; set; }
        public FontStyle Style { get; set; }
		public string Name {get; set;}

        public Font(FontFamily family, int size, FontStyle style)
        {
            Size = size;
            FontFamily = family;
            Style = style;
        }

        public Font(FontFamily family, int size)
        {
            Size = size;
            FontFamily = family;
            Style = FontStyle.Normal;
        }

		public Font(string familyName, float emSize)
		{
			this.Size = (int)emSize;
			this.Style = FontStyle.Normal;
			this.FontFamily  = Drawing.FontFamily.GenericSansSerif;
			this.Name = familyName;

			
			throw new NotImplementedException();

		}

		public Font(FontFamily family, float emSize, FontStyle style)
		{
			throw new NotImplementedException();
		}

		public Font(string familyName, float emSize, FontStyle style)
		{
			throw new NotImplementedException();
		}

        #region IDisposable Members

        public void Dispose()
        {
        }

        #endregion
    }
}