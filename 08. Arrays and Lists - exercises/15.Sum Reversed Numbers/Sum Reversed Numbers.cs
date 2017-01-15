using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                string n = string.Empty;
                int currentNumberLength = numbers[i].ToString().Length;
                while (true)
                {
                    int lastDigit = numbers[i] % 10;
                    n += lastDigit.ToString();
                    if (n.Length == currentNumberLength)
                    {
                        break;
                    }
                    numbers[i] /= 10;
                }
                numbers[i] = int.Parse(n);
            }
            int result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                result += numbers[i];
            }
            Console.WriteLine(result);
        }
    }
}