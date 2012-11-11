using System;
using Android.Graphics;

namespace System.Drawing
{
	public class Bitmap : Image
	{
		
		/// <summary>
		/// Initializes a new instance of the Bitmap class from the specified existing image.
		/// </summary>
		/// <param name='img'>
		/// Image.
		/// </param>
		public Bitmap (Image img)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Initializes a new instance of the Bitmap class from the specified data stream.
		/// </summary>
		/// <param name='img'>
		/// Image.
		/// </param>
		public Bitmap (System.IO.Stream img)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Initializes a new instance of the Bitmap class from the specified file.
		/// </summary>
		/// <param name='file'>
		/// File.
		/// </param>
		public Bitmap(String file)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Initializes a new instance of the Bitmap class from the specified existing image, scaled to the specified size.
		/// </summary>
		/// <param name='img'>
		/// Image.
		/// </param>
		/// <param name='sz'>
		/// Size.
		/// </param>
		public Bitmap(Image img , Size sz)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Initializes a new instance of the Bitmap class with the specified size.
		/// </summary>
		/// <param name='x'>
		/// The x coordinate.
		/// </param>
		/// <param name='y'>
		/// The y coordinate.
		/// </param>
		public Bitmap(int x, int y)
		{
			throw new NotImplementedException();
		}

		private Android.Graphics.Bitmap _androidBitMap;
		public Android.Graphics.Bitmap AndroidBitmap 
		{
			get
			{
				return _androidBitMap;
			}
		}

		/// <summary>
		/// Gets the width, in pixels, of this Image.
		/// </summary>
		/// <value>
		/// The width.
		/// </value>
		public override int Width
		{
			get 
			{
				return _androidBitMap.Width;
			}
		}

		public override int Height
		{
			get
			{
				return _androidBitMap.Height;
			}
		}


		public System.Drawing.Size Size
		{
			get
			{
				return new System.Drawing.Size(_androidBitMap.Width, _androidBitMap.Height);
			}
		}

		#region IDisposable Members
		
		public void Dispose()
		{
			/*
			this.paint.Dispose();
			
			if (this.ownCanvas)
			{
				this.canvas.Dispose();
			}
			*/
		}
		
		#endregion

	}
}

