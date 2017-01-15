using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing
{
    class Program
    {
        static void Main(string[] args)
        {
            // 71/100 in Judge
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = 1;
            int bestLength = 1;

            int bestStart = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1] + 1)
                {
                    length++;


                }
                else
                {
                    length = 1;
                }
                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = nums[i - bestLength + 1];
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(bestStart + i + " ");
            }
        }
    }
}