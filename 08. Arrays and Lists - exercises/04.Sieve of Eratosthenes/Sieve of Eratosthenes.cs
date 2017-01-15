using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static List<int> GetPrimeNumbers(int end)
        {
            var result = new List<int>();

            for (int number = 0; number <= end; number++)
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
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numbers = String.Join(", ", GetPrimeNumbers(n).ToArray());
            Console.WriteLine(numbers);

        }
    }
}
