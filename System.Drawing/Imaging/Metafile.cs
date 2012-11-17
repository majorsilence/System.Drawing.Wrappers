using System;

namespace System.Drawing.Imaging
{
	public class Metafile : Image
	{

		public Metafile(System.IO.Stream stream)
		{
			throw new NotImplementedException();		
		}

		/// <summary>
		/// Initializes a new instance of the Metafile class from the 
		/// specified data stream, a Windows handle to a device context, 
		/// a Rectangle structure that represents the rectangle that bounds 
		/// the new Metafile, and the supplied unit of measure.
		/// </summary>
		/// <param name=''>
		/// .
		/// </param>
		public Metafile(System.IO.Stream stream, System.IntPtr ptr, Drawing.Rectangle rect, MetafileFrameUnit unit)
		{

			throw new NotImplementedException();
		}


		public Metafile(System.IO.Stream stream, System.IntPtr ptr, Drawing.RectangleF rect, MetafileFrameUnit unit)
		{
			
			throw new NotImplementedException();
		}
		
		/// <summary>
		/// Saves this image to the specified stream in the specified format.
		/// </summary>
		/// <param name='stream'>
		/// Stream.
		/// </param>
		/// <param name='imgFormat'>
		/// Image format.
		/// </param>
		public void Save(System.IO.Stream stream, ImageFormat imgFormat)
		{
			throw new NotImplementedException();
		}

		public override int Width
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public override int Height
		{
			get
			{
				throw new NotImplementedException();
			}
		}

	}
}

