using System;

namespace System.Drawing.Drawing2D
{
	public class HatchBrush : Brush
	{
		public HatchBrush (HatchStyle style)
		{
			_hatchStyle = style;
			throw new NotImplementedException();
		}

		public HatchBrush(HatchStyle style, Color foreground, Color background)
		{
			_hatchStyle = style;
			_foregroundColor = foreground;
			_backgroundColor = background;
			throw new NotImplementedException();
		}


		private Color _backgroundColor;
		public Color BackgroundColor
		{
			get
			{
				return _backgroundColor;
			}
		}

		private Color _foregroundColor;
		public Color ForegroundColor
		{
			get
			{
				return _foregroundColor;
			}
		}

		private HatchStyle _hatchStyle;
		public HatchStyle HatchStyle
		{
			get
			{
				return _hatchStyle;
			}
		}


		public void Dispose()
		{
		}

	}
}

