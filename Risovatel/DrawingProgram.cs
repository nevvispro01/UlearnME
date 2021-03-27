using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace RefactorMe
{
    class Drawing
    {
        static float x, y;
        static Graphics graphics;

        public static void Initialize ( Graphics novayaGraphics )
        {
            graphics = novayaGraphics;
            graphics.SmoothingMode = SmoothingMode.None;
            graphics.Clear(Color.Black);
        }

        public static void Set_position(float x0, float y0)
        {
            x = x0; y = y0;
        }

        public static void MakeIt(Pen pen, double length, double angle)
        {
            //Делает шаг длиной dlina в направлении ugol и рисует пройденную траекторию
            var x1 = (float)(x + length * Math.Cos(angle));
            var y1 = (float)(y + length * Math.Sin(angle));
            graphics.DrawLine(pen, x, y, x1, y1);
            x = x1;
            y = y1;
        }

        public static void Change(double length, double angle)
        {
            x = (float)(x + length * Math.Cos(angle)); 
            y = (float)(y + length * Math.Sin(angle));
        }
    }

    public class ImpossibleSquare
    {
        public static void Draw(int width, int height, double angleOfRotation, Graphics graphics)
        {
            // ugolPovorota пока не используется, но будет использоваться в будущем
            Drawing.Initialize(graphics);

            var sz = Math.Min(width, height);

            var diagonal_length = Math.Sqrt(2) * (sz * 0.375f + sz * 0.04f) / 2;
            var x0 = (float)(diagonal_length * Math.Cos(Math.PI / 4 + Math.PI)) + width / 2f;
            var y0 = (float)(diagonal_length * Math.Sin(Math.PI / 4 + Math.PI)) + height / 2f;

            Drawing.Set_position(x0, y0);

            DrawOneSide(sz);

            DrawTwoSide(sz);

            DrawthreeSide(sz);

            DrawfourSide(sz);
        }

        public static void DrawOneSide(int sz)
        {
            //Рисуем 1-ую сторону
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f, 0);
            Drawing.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI / 4);
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI);
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI / 2);

            Drawing.Change(sz * 0.04f, -Math.PI);
            Drawing.Change(sz * 0.04f * Math.Sqrt(2), 3 * Math.PI / 4);
        }

        public static void DrawTwoSide(int sz)
        {
            //Рисуем 2-ую сторону
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f, -Math.PI / 2);
            Drawing.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f, -Math.PI / 2 + Math.PI);
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, -Math.PI / 2 + Math.PI / 2);

            Drawing.Change(sz * 0.04f, -Math.PI / 2 - Math.PI);
            Drawing.Change(sz * 0.04f * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4);
        }

        public static void DrawthreeSide(int sz)
        {
            //Рисуем 3-ю сторону
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI);
            Drawing.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI + Math.PI / 4);
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI + Math.PI);
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI + Math.PI / 2);

            Drawing.Change(sz * 0.04f, Math.PI - Math.PI);
            Drawing.Change(sz * 0.04f * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4);
        }

        public static void DrawfourSide(int sz)
        {
            //Рисуем 4-ую сторону
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI / 2);
            Drawing.MakeIt(Pens.Yellow, sz * 0.04f * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f, Math.PI / 2 + Math.PI);
            Drawing.MakeIt(Pens.Yellow, sz * 0.375f - sz * 0.04f, Math.PI / 2 + Math.PI / 2);

            Drawing.Change(sz * 0.04f, Math.PI / 2 - Math.PI);
            Drawing.Change(sz * 0.04f * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4);
        }
    }
}