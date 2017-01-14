using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class cube
    {
        //80/100 in Judge
        static double GetFaceDiagonals(double s)
        {
            double faceDiagonals = Math.Sqrt(2 * (Math.Pow(s, 2)));
            return faceDiagonals;
        }
        static double GetSpaceDiagonals(double s)
        {
            double spaceDiagonals = Math.Sqrt(3 * (Math.Pow(s, 2)));
            return spaceDiagonals;
        }
        static double GetVolume(double s)
        {
            double volume = Math.Pow(s, 3);
            return volume;
        }
        static double GetSurface(double s)
        {
            double surface = 6 * (Math.Pow(s, 2));
            return surface;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                Console.WriteLine("{0:F2}", GetFaceDiagonals(side));
            }
            else if (parameter == "space")
            {
                Console.WriteLine("{0:F2}", GetSpaceDiagonals(side));
            }
            else if (parameter == "volume")
            {
                Console.WriteLine("{0:F2}", GetVolume(side));
            }
            else if (parameter == "surface")
            {
                Console.WriteLine("{0:F2}", GetSurface(side));
            }
        }
    }
}



