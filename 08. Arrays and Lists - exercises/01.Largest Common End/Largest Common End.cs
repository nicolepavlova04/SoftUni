using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();
            int counter = 0;
            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] == arr2[i])
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                Array.Reverse(arr1);
                Array.Reverse(arr2);
                for (int j = 0; j < Math.Min(arr1.Length, arr2.Length); j++)
                {
                    if (arr1[j] == arr2[j])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}

