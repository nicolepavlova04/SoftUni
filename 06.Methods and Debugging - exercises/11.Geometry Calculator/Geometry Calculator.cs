using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static double GetTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = (side * height) / 2;
            return result;
        }
        static double GetSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            double result = Math.Pow(side, 2);
            return result;
        }
        static double GetRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double result = width * height;
            return result;
        }
        static double GetCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            double result = Math.PI * (Math.Pow(radius, 2));
            return result;
        }
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "triangle")
            {
                Console.WriteLine("{0:F2}", GetTriangleArea());
            }
            else if (figure == "square")
            {
                Console.WriteLine("{0:F2}", GetSquareArea());
            }
            else if (figure == "rectangle")
            {

                Console.WriteLine("{0:F2}", GetRectangleArea());
            }
            else if (figure == "circle")
            {
                Console.WriteLine("{0:F2}", GetCircleArea());
            }
        }
    }
}
