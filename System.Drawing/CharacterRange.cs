using System;

namespace System.Drawing
{
	public struct CharacterRange
	{

		public CharacterRange(int first, int length)
		{
			_first = first;
			_length = length;
		}

		private int _first;
		public int First
		{
			get
			{
				return _first;
			}
			set
			{
				_first = value;
			}
		}

		private int _length;
		public int Length
		{
			get
			{
				return _length;
			}
			set
			{
				_length = value;
			}
		}

	}
}

