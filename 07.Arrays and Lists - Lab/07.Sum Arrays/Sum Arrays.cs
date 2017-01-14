using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] maxLenght = new int[Math.Max(arr1.Length, arr2.Length)];
            int sum = Math.Max(arr1.Length, arr2.Length);
            for (int i = 0; i <= maxLenght.Length; i++)
            {
                sum = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);
                if (i >= maxLenght.Length)
                {
                    break;
                }
                Console.Write(sum + " ");
            }
        }
    }
}
