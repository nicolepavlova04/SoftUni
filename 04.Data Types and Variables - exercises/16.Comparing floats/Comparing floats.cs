using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double esp = 0.000001;
            double difference = Math.Abs(num1 - num2);
            bool isTrue;
            if (difference > esp)
            {
                isTrue = false;
                Console.WriteLine(isTrue);

            }
            else if (difference < esp)
            {
                isTrue = true;
                Console.WriteLine(isTrue);
            }
        }
    }
}

