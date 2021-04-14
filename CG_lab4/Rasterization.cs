using System;
using System.Collections.Generic;

namespace CG_lab4
{
    class Rasterization
    {
        
        public static HashSet<KeyValuePair<int, int>> StepByStep(int x1, int y1, int x2, int y2)
        {
            HashSet<KeyValuePair<int, int>> linePoints = new HashSet<KeyValuePair<int, int>>();

            var steep = Math.Abs(y2 - y1) > Math.Abs(x2 - x1);
            if (steep)
            {
                Swap(ref x1, ref y1);
                Swap(ref x2, ref y2);
            }

            if (x1 > x2)
            {
                Swap(ref x1, ref x2);
                Swap(ref y1, ref y2);
            }

            if (x1 == x2)
            {
                for (int i = y1; i <= y2; i++)
                {
                    linePoints.Add(new KeyValuePair<int, int>(x1, i));
                }
                return linePoints;
            }
            else
            {
                int dx = x2 - x1;
                int dy = y2 - y1;
                double k = (double)dy / dx;
                double b = y1 - k * x1;
                int newY;

                for (int i = x1; i <= x2; i++)
                {
                    newY = (int)Math.Round(k * i + b);
                    linePoints.Add(new KeyValuePair<int, int>(steep ? newY : i, steep ? i : newY));
                }
            }

            return linePoints;
        }

        public static HashSet<KeyValuePair<int, int>> DDA(int x1, int y1, int x2, int y2)
        {
            HashSet<KeyValuePair<int, int>> linePoints = new HashSet<KeyValuePair<int, int>>();
            double dx = (x2 - x1);
            double dy = (y2 - y1);
            double L = Math.Max(Math.Abs(dx), Math.Abs(dy));
            double x = x1, y = y1;
            linePoints.Add(new KeyValuePair<int, int>(x1, y1));

            for (int i = 1; i < L; i++)
            {
                x = x + dx / L;
                y = y + dy / L;
                linePoints.Add(new KeyValuePair<int, int>((int)Math.Round(x), (int)Math.Round(y)));
            }
            linePoints.Add(new KeyValuePair<int, int>(x2, y2));
            return linePoints;
        }

        public static HashSet<KeyValuePair<int, int>> Bresenham(int x1, int y1, int x2, int y2)
        {
            HashSet<KeyValuePair<int, int>> linePoints = new HashSet<KeyValuePair<int, int>>();

            var steep = Math.Abs(y2 - y1) > Math.Abs(x2 - x1);
            if (steep)
            {
                Swap(ref x1, ref y1);
                Swap(ref x2, ref y2);
            }

            if (x1 > x2)
            {
                Swap(ref x1, ref x2);
                Swap(ref y1, ref y2);
            }

            int dx = x2 - x1;
            int dy = Math.Abs(y2 - y1);
            int error = dx / 2;
            int ystep = (y1 < y2) ? 1 : -1;
            int y = y1;
            for (int x = x1; x <= x2; x++)
            {
                linePoints.Add(new KeyValuePair<int, int>(steep ? y : x, steep ? x : y));
                error -= dy;
                if (error < 0)
                {
                    y += ystep;
                    error += dx;
                }
            }

            return linePoints;
        }

        public static HashSet<KeyValuePair<int, int>> BresenhamCircle(int x1, int y1, int r)
        {

            HashSet<KeyValuePair<int, int>> linePoints = new HashSet<KeyValuePair<int, int>>();

            int X = 0;
            int Y = r;
            int E = 3 - 2 * r;

            linePoints.Add(new  KeyValuePair<int, int>(X + x1, Y + y1));
            linePoints.Add(new  KeyValuePair<int, int>(X + x1, -Y + y1));
            linePoints.Add(new  KeyValuePair<int, int>(-X + x1, Y + y1));
            linePoints.Add(new  KeyValuePair<int, int>(-X + x1, -Y + y1));

            linePoints.Add(new  KeyValuePair<int, int>(Y + x1, X + y1));
            linePoints.Add(new  KeyValuePair<int, int>(-Y + x1, X + y1));
            linePoints.Add(new  KeyValuePair<int, int>(Y + x1, -X + y1));
            linePoints.Add(new  KeyValuePair<int, int>(-Y + x1, -X + y1));
            while (X < Y)
            {
                if (E >= 0)
                {
                    E = E + 4 * (X - Y) + 10;
                    X += 1;
                    Y -= 1;
                }
                else
                {
                    E = E + 4 * X + 6;
                    X += 1;
                }

                linePoints.Add(new  KeyValuePair<int, int>(X + x1, Y + y1));
                linePoints.Add(new  KeyValuePair<int, int>(X + x1, -Y + y1));
                linePoints.Add(new  KeyValuePair<int, int>(-X + x1, Y + y1));
                linePoints.Add(new  KeyValuePair<int, int>(-X + x1, -Y + y1));

                linePoints.Add(new  KeyValuePair<int, int>(Y + x1, X + y1));
                linePoints.Add(new  KeyValuePair<int, int>(-Y + x1, X + y1));
                linePoints.Add(new  KeyValuePair<int, int>(Y + x1, -X + y1));
                linePoints.Add(new  KeyValuePair<int, int>(-Y + x1, -X + y1));           
            }

            return (linePoints);
        }

        private static void Swap(ref int x1, ref int x2)
        {
            int t = x2;
            x2 = x1;
            x1 = t;
        }
    }
}