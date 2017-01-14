using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfStrings = Console.ReadLine().Split(' ').ToArray();


            for (var i = arrayOfStrings.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayOfStrings[i] + " ");
            }
        }


    }
}


