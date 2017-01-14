using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {roundedNumbers[i]}");
            }



        }
    }
}
