using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static string PrintReversed(string n)
        {
            string result = "";
            for (int i = n.Length - 1; i >= 0; i--)
            {
                result += n[i];

            }
            return result;
        }
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            string reversedNumber = PrintReversed(num);
            Console.WriteLine(reversedNumber);
        }
    }
}
