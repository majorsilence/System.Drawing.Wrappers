using System;

namespace System.Drawing.Imaging
{
	public sealed class ImageFormat
	{

		private static ImageFormat _bmp;
		public static ImageFormat Bmp 
		{
			get
			{
				return _bmp;
			}
		}

		private static ImageFormat _jpg;
		public static ImageFormat Jpeg 
		{
			get
			{
				return _jpg;
			}
		}

		private static ImageFormat _emf;
		public static ImageFormat Emf 
		{
			get
			{
				return _emf;
			}
		}

		private static ImageFormat _gif;
		public static ImageFormat Gif
		{
			get
			{
				return _gif;
			}
		}

		private static ImageFormat _icon;
		public static ImageFormat Icon 
		{
			get
			{
				return _icon;
			}
		}

		private static ImageFormat _png;
		public static ImageFormat Png 
		{
			get
			{
				return _png;
			}
		}


		private static ImageFormat _tiff;
		public static ImageFormat Tiff 
		{
			get
			{
				return _tiff;
			}
		}


		private static ImageFormat _wmf;
		public static ImageFormat Wmf 
		{
			get
			{
				return _wmf;
			}
		}

	}



}

