using System;

namespace System.Drawing.Imaging
{

	public sealed class Encoder
	{
		public Encoder ()
		{
		}

		private Guid _guid;
		public Guid Guid 
		{ 
			get
			{
				return _guid;
			}
		}

		public static Encoder ChrominanceTable
		{
			get
			{
				Encoder e = new Encoder();
				e._guid = new Guid("f2e455dc-09b3-4316-8260-676ada32481c");
				return e;
			}
		}

		public static Encoder ColorDepth
		{
			get
			{
				Encoder e = new Encoder();
				e._guid = new Guid("66087055-ad66-4c7c-9a18-38a2310b8337");
				return e;
			}
		}


		public static Encoder Compression
		{
			get
			{
				Encoder e = new Encoder();
				e._guid = new Guid("e09d739d-ccd4-44ee-8eba-3fbf8be4fc58");
				return e;
			}
		}

		public static Encoder LuminanceTable
		{
			get
			{
				Encoder e = new Encoder();
				e._guid = new Guid("edb33bce-0266-4a77-b904-27216099e717");
				return e;
			}
		}

		public static Encoder Quality
		{
			get
			{
				Encoder e = new Encoder();
				e._guid = new Guid("1d5be4b5-fa4a-452d-9cdd-5db35105e7eb");
				return e;
			}
		}

		public static Encoder RenderMethod
		{
			get
			{
				Encoder e = new Encoder();
				e._guid = new Guid("6d42c53a-229a-4825-8bb7-5c99e2b9a8b8");
				return e;
			}
		}

		public static Encoder SaveFlag
		{
			get
			{
				Encoder e = new Encoder();
				e._guid = new Guid("292266fc-ac40-47bf-8cfc-a85b89a655de");
				return e;
			}
		}

		public static Encoder ScanMethod
		{
			get
			{
				Encoder e = new Encoder();
				e._guid = new Guid("3a4e2661-3109-4e56-8536-42c156e7dcfa");
				return e;
			}
		}

		public static Encoder Transformation
		{
			get
			{
				Encoder e = new Encoder();
				e._guid = new Guid("8d0eb2d1-a58e-4ea8-aa14-108074b7b6f9");
				return e;
			}
		}

		public static Encoder Version
		{
			get
			{
				Encoder e = new Encoder();
				e._guid = new Guid("24d18c76-814a-41a4-bf53-1c219cccf797");
				return e;
			}
		}

	}
}

