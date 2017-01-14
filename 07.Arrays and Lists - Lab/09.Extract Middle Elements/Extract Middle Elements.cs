using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int arrLenght = arr.Length;
            if (arrLenght == 1)
            {
                Console.WriteLine(arr[0]);
                return;
            }
            if (arrLenght % 2 == 0)
            {
                Console.WriteLine("{0} {1}", arr[arrLenght / 2 - 1], arr[arrLenght / 2]);
            }
            if (arrLenght % 2 != 0)
            {
                Console.WriteLine("{0} {1} {2}", arr[arrLenght / 2 - 1], arr[arrLenght / 2], arr[arrLenght / 2 + 1]);

            }
        }
    }
}
