using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int start = 0;
            int len = 1;
            int bestLen = 0;


            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    len++;

                }

                if (bestLen < len)
                {
                    bestLen = len;
                    start = numbers[i];
                }
                if (numbers[i] != numbers[i + 1])
                {
                    len = 1;
                }
            }
            List<int> output = new List<int>();
            for (int j = 0; j < bestLen; j++)
            {
                output.Add(start);

            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
