using System;

namespace System.Drawing.Imaging
{
	public class ImageCodecInfo
	{
		public ImageCodecInfo ()
		{
		}

		public Guid Clsid {get; set;}

		public string CodecName { get; set; }

		public string DllName { get; set; }

		public string FilenameExtension { get; set; }

		public ImageCodecFlags Flags { get; set; }

		public string FormatDescription { get; set; }

		public Guid FormatID { get; set; }

		public string MimeType { get; set; }

		[CLSCompliantAttribute(false)]
		public byte[][] SignatureMasks { get; set; }

		[CLSCompliantAttribute(false)]
		public byte[][] SignaturePatterns { get; set; }
		
		public int Version { get; set; }

		public static ImageCodecInfo[] GetImageEncoders()
		{

			ImageCodecInfo []ici;
			ici = new ImageCodecInfo[2];

			ici[0].CodecName = "JPEG";
			ici[0].MimeType = "image/jpeg";
			ici[0].FilenameExtension = ".jpg";

			ici[0].CodecName = "PNG";
			ici[0].MimeType = "image/PNG";
			ici[0].FilenameExtension = ".png";

			throw new NotImplementedException();

		}

		public static ImageCodecInfo[] GetImageDecoders()
		{
			
			ImageCodecInfo []ici;
			ici = new ImageCodecInfo[2];
			
			ici[0].CodecName = "JPEG";
			ici[0].MimeType = "image/jpeg";
			ici[0].FilenameExtension = ".jpg";
			
			ici[0].CodecName = "PNG";
			ici[0].MimeType = "image/PNG";
			ici[0].FilenameExtension = ".png";
			
			throw new NotImplementedException();
			
		}

	}
}

