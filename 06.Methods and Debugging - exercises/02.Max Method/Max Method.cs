using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static int GetMax(int a, int b, int c)
        {
            int aB = Math.Max(a, b);
            int bC = Math.Max(b, c);
            int result = Math.Max(aB, bC);

            return result;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a, b, c));
        }
    }
}
