using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNumbers = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                var num = input[i];
                if (Math.Sqrt(num) == (int)(Math.Sqrt(num)))
                {
                    squareNumbers.Add(num);
                }
                squareNumbers.Sort((a, b) => b.CompareTo(a));

            }
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}

