using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			double distanceToA = Math.Sqrt((ax - x) * (ax - x) + (ay - y) * (ay - y));
            double distanceToB = Math.Sqrt((bx - x) * (bx - x) + (by - y) * (by - y));
			double x11 = x - ax;
			double y11 = y - ay;
			double x12 = bx - ax;
			double y12 = by - ay;
			double x21 = x - bx;
			double y21 = y - by;
			double x22 = ax - bx;
			double y22 = ay - by;
			double cos1 = (x11 * x12 + y11 * y12) / (Math.Sqrt(x11 * x11 + y11 * y11) * Math.Sqrt(x12 * x12 + y12 * y12));
			double cos2 = (x21 * x22 + y21 * y22) / (Math.Sqrt(x21 * x21 + y21 * y21) * Math.Sqrt(x22 * x22 + y22 * y22));
			if ((ax == bx)&&(ay == by))
			{
				return Math.Sqrt((ax - x) * (ax - x) + (ay - y) * (ay - y));
			}
			else if (Math.Acos(cos1) >= 1.57)
            {
				return distanceToA;
			}
			else if (Math.Acos(cos2) >= 1.57)
            {
				return distanceToB;

            }
			return Math.Abs((by - ay) * x - (bx - ax) * y + bx * ay - by * ax) / Math.Sqrt((by - ay) * (by - ay) + (bx - ax) * (bx - ax));
        }
	}
}