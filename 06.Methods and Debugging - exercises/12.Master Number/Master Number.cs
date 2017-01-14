using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Number
{
    class Program
    {
        static bool IsPalindrome(int num)
        {
            bool isPalidrome = true;
            int t = num;
            int a, s = 0;

            while (num > 0)
            {
                a = num % 10;
                s = s * 10 + a;
                num = num / 10;
            }
            if (t == s)
            {
                isPalidrome = true;
            }
            else
            {
                isPalidrome = false;
            }
            return isPalidrome;
        }
        static bool SumOfDigits(int num)
        {
            bool isDivisibleBy7 = true;
            int sum = 0;
            do
            {
                sum += (num % 10);
                num /= 10;

            } while (num > 0);

            if (sum % 7 == 0)
            {
                isDivisibleBy7 = true;
            }
            else
            {
                isDivisibleBy7 = false;
            }
            return isDivisibleBy7;
        }
        static bool ContainsEvenDigit(int num)
        {
            bool isEven = true;
            int result = 0;
            do
            {
                result = num % 10;
                num /= 10;
                if (result % 2 == 0)
                {
                    isEven = true;
                    break;
                }
                else
                {
                    isEven = false;
                }
            } while (num > 0);
            return isEven;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (IsPalindrome(i))
                {
                    if (SumOfDigits(i))
                    {
                        if (ContainsEvenDigit(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }


            }


        }
    }
}
