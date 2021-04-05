using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			var x11 = r1.Left;
			var x12 = r1.Left + r1.Width;
			var x21 = r2.Left;
			var x22 = r2.Left + r2.Width;
			var y11 = r1.Top;
			var y12 = r1.Top + r1.Height;
			var y21 = r2.Top;
			var y22 = r2.Top + r2.Height;
			if ((x11 >= x21)&&(x11 <= x22)&&(y11 >= y21) && (y11 <= y22)||(x11 >= x21) && (x11 <= x22) && (y12 >= y21) && (y12 <= y22)||(x12 >= x21) && (x12 <= x22) && (y11 >= y21) && (y11 <= y22) || (x12 >= x21) && (x12 <= x22) && (y12 >= y21) && (y12 <= y22))
            {
				return true;
			}
			else if ((x21 >= x11) && (x21 <= x12) && (y21 >= y11) && (y21 <= y12) || (x21 >= x11) && (x21 <= x12) && (y22 >= y11) && (y22 <= y12) || (x22 >= x11) && (x22 <= x12) && (y21 >= y11) && (y21 <= y12) || (x22 >= x11) && (x22 <= x12) && (y22 >= y11) && (y22 <= y12))
			{
				return true;
            }
			else if ((x11 >= x21) && (x11 <= x22) && (y21 >= y11) && (y21 <= y12) || (x11 >= x21) && (x11 <= x22) && (y22 >= y11) && (y22 <= y12) || (x12 >= x21) && (x12 <= x22) && (y21 >= y11) && (y21 <= y12) || (x12 >= x21) && (x12 <= x22) && (y22 >= y11) && (y22 <= y12))
			{
				return true;
			}
			else if ((x21 >= x11) && (x21 <= x12) && (y11 >= y21) && (y11 <= y22) || (x21 >= x11) && (x21 <= x12) && (y12 >= y21) && (y12 <= y22) || (x22 >= x11) && (x22 <= x12) && (y11 >= y21) && (y11 <= y22) || (x22 >= x11) && (x22 <= x12) && (y12 >= y21) && (y12 <= y22))
			{
				return true;
			}
			else
            {
				return false;
			}
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			var x11 = r1.Left;
			var x12 = r1.Left + r1.Width;
			var x21 = r2.Left;
			var x22 = r2.Left + r2.Width;
			var y11 = r1.Top;
			var y12 = r1.Top + r1.Height;
			var y21 = r2.Top;
			var y22 = r2.Top + r2.Height;
			int xLength;
			int yLength;
			if ((x12 < x21)||(x11 > x22))
            {
				return 0;
            }
			if ((y12 < y21) || (y11 > y22))
			{
				return 0;
			}
			if (x11 <= x21)
            {
				if (x12 >= x22)
                {
					xLength = r2.Width;
                }
                else
                {
					xLength = r2.Width - (x22 - x12);
                }
            }
            else if (x11 <= x22)
            {
				if (x12 <= x22)
                {
					xLength = r1.Width;
				}
				else
                {
					xLength = r1.Width - (x12 - x22);
				}
            }
            else
            {
				return 0;
            }

			if (y11 <= y21)
			{
				if (y12 >= y22)
				{
					yLength = r2.Height;
				}
				else
				{
					yLength = r2.Height - (y22 - y12);
				}
			}
			else if (y11 <= y22)
			{
				if (y12 <= y22)
				{
					yLength = r1.Height;
				}
				else
				{
					yLength = r1.Height - (y12 - y22);
				}
			}
			else
			{
				return 0;
			}
			return xLength * yLength;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			var x11 = r1.Left;
			var x12 = r1.Left + r1.Width;
			var x21 = r2.Left;
			var x22 = r2.Left + r2.Width;
			var y11 = r1.Top;
			var y12 = r1.Top + r1.Height;
			var y21 = r2.Top;
			var y22 = r2.Top + r2.Height;
			if ((x11 >= x21)&&(x12 <= x22)&&(y11 >= y21)&&(y12 <= y22))
            {
				return 0;
            }
            else if ((x21 >= x11) && (x22 <= x12) && (y21 >= y11) && (y22 <= y12))
			{
				return 1;
            }
            else
            {
				return -1;
			}
		}
	}
}