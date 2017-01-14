using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            var courses = n / c;

            if (n % c != 0)
            {
                courses += 1;

            }
            Console.WriteLine(courses);
        }
    }
}
