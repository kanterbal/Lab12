using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vvedite radius okruznosti. R=");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dlina okruznosti = {0:N5}",Circle.Length(r));
            Console.WriteLine("Plosad kruga = {0:N5}", Circle.Area(r));
            Console.Write("Vvedite koordinatu okruznosti. x0=");
            int x0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite koordinatu okruznosti. y0=");
            int y0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite koordinatu tocki. x=");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite koordinatu tocki. y=");
            int y = Convert.ToInt32(Console.ReadLine());
            bool pointInCircle = Circle.PointInCircle(x, y, r, x0, y0);
            if (pointInCircle)
            {
                Console.WriteLine("Tocka x,y prinadlezit krugu");
            }
            else
            {
                Console.WriteLine("Tocka x,y ne prinadlezit krugu");
            }

            Console.ReadKey();
        }

        public static class Circle
        {
            public static double Length(double r)
            {
                return 2 * Math.PI * r;
            }
            public static double Area(double r)
            {
                return Math.PI * Math.Pow(r, 2);
            }
            public static bool PointInCircle(int x, int y, double r, int x0, int y0)
            {
                if ((Math.Pow(x-x0,2)+Math.Pow(y-y0,2)) <= Math.Pow(r,2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
