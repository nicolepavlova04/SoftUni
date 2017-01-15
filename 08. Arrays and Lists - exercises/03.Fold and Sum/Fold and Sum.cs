using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fold_and_sum_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            List<int> firstAndLastNumbers = new List<int>();
            List<int> middleNumbers = new List<int>();
            for (int i = 0; i < k; i++)
            {
                firstAndLastNumbers.Add(arr[i]);

            }
            firstAndLastNumbers.Reverse();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                middleNumbers.Add(arr[k + i]);
            }

            Array.Reverse(arr);

            for (int i = 0; i < k; i++)
            {
                firstAndLastNumbers.Add(arr[i]);

            }



            int[] sum = new int[k * 2];
            for (int i = 0; i < k * 2; i++)
            {
                sum[i] = firstAndLastNumbers[i] + middleNumbers[i];

            }
            Console.WriteLine(string.Join(" ", sum));




        }
    }
}
