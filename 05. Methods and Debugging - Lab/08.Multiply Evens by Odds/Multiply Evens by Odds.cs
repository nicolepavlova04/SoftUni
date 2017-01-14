using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Evens_by_Odds
{
    class Program
    {
        static int SumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
        static int SumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
        static int MultipleOfEvensAndOdds(int n)
        {
            int sumEvens = SumOfEvenDigits(n);
            int sumOdds = SumOfOddDigits(n);
            return (sumEvens * sumOdds);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            Console.WriteLine(MultipleOfEvensAndOdds(n));
        }
    }
}
