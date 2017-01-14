using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int positions = int.Parse(Console.ReadLine());

            int[] arr = new int[positions];
            for (int i = 0; i < positions; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int j = positions - 1; j >= 0; j--)
            {
                Console.Write(arr[j] + " ");
                Console.WriteLine();
            }

        }
    }
}
