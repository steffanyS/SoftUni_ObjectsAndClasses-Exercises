using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CirclesIntersection
{
    class CirclesIntersection
    {
        static void Main(string[] args)
        {
            var firstCircleInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondCircleInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point firstCenter = new Point
            {
                X = firstCircleInput[0],
                Y = firstCircleInput[1]
            };

            Point secondCenter = new Point
            {
                X = secondCircleInput[0],
                Y = secondCircleInput[1]
            };

            Circle firstCircle = new Circle
            {
                Center = firstCenter,
                Radius = firstCircleInput[2]
            };

            Circle secondCircle = new Circle
            {
                Center = secondCenter,
                Radius = secondCircleInput[2]
            };

            if (Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else if (Intersect(secondCircle, firstCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
             var distance= Math.Sqrt(Math.Pow((c2.Center.X - c1.Center.X),2 ) + Math.Pow((c2.Center.Y - c1.Center.Y), 2));
            if (distance <= c1.Radius + c2.Radius)
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
