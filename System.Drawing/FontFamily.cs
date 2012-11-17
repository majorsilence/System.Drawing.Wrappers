namespace System.Drawing
{
    using Android.Graphics;

    public class FontFamily
    {
        static FontFamily()
        {
            GenericMonospace = new FontFamily(Typeface.Monospace);
            GenericSansSerif = new FontFamily(Typeface.SansSerif);
            GenericSerif = new FontFamily(Typeface.Serif);
        }

        public FontFamily(Typeface typeface)
        {
            Typeface = typeface;
        }

		public FontFamily(string fontFamily)
		{
			throw new NotImplementedException();
		}

        public Typeface Typeface { get; private set; }

        public static FontFamily GenericMonospace { get; private set; }
        public static FontFamily GenericSansSerif { get; private set; }
        public static FontFamily GenericSerif { get; private set; }

		public int GetCellDescent(FontStyle style)
		{
			throw new NotImplementedException();
		}


		public int GetEmHeight(FontStyle style)
		{
			throw new NotImplementedException();
		}

    }
}