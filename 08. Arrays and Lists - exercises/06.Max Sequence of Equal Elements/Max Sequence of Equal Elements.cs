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
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int lenght = 1;
            int bestLenght = 0;


            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    lenght++;

                }

                if (bestLenght < lenght)
                {
                    bestLenght = lenght;
                    start = numbers[i];
                }
                if (numbers[i] != numbers[i + 1])
                {
                    lenght = 1;
                }
            }
            int[] output = new int[bestLenght];
            for (int j = 0; j < output.Length; j++)
            {
                output[j] = start;
                Console.Write(string.Join(" ", output[j] + " "));
            }
        }
    }
}
