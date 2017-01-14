using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> numbers = input.Split('|').ToList();
            List<string> result = new List<string>();
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                result.Add(string.Join(" ", numbers[i].Split(' ')));
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
