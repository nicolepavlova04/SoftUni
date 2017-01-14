using System;
using System.Collections.Generic;

namespace FastPrimeCheckerRefactor
{
    public class Program
    {
        static List<int> GetPrimeNumbers(int start, int end)
        {
            var result = new List<int>();
            if (start < 2)
            {
                start = 2;
            }
            for (int number = start; number <= end; number++)
            {
                bool isPrime = true;
                if (number < 2)
                {
                    isPrime = false;
                }
                for (int divider = 2; divider <= Math.Sqrt(number); divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    result.Add(number);
                }

            }
            return result;
        }
        public static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());
            string numbers = String.Join(", ", GetPrimeNumbers(startNumber, stopNumber).ToArray());
            Console.WriteLine(numbers);
        }
    }
}
