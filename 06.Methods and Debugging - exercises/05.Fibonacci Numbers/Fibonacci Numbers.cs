using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static int Fib(int num)
        {
            int a = 0;
            int b = 1;
            for (int counter = 0; counter <= num; counter++)
            {
                int aA = a;
                a = b;
                b = aA + b;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(num));
        }
    }
}
