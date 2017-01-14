using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_Last_Digit
{
    class Program
    {

        static string GetTheNameOfTheLastDigit(long number)
        {
            string lastDigitString = "";
            long lastDigitInt = number % 10;


            switch (lastDigitInt)
            {
                case 1: lastDigitString = "one"; break;
                case 2: lastDigitString = "two"; break;
                case 3: lastDigitString = "three"; break;
                case 4: lastDigitString = "four"; break;
                case 5: lastDigitString = "five"; break;
                case 6: lastDigitString = "six"; break;
                case 7: lastDigitString = "seven"; break;
                case 8: lastDigitString = "eight"; break;
                case 9: lastDigitString = "nine"; break;
                case 0: lastDigitString = "zero"; break;
                default:
                    break;
            }
            return lastDigitString;
        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            number = Math.Abs(number);
            string lastDigit = GetTheNameOfTheLastDigit(number);
            Console.WriteLine(lastDigit);
        }
    }
}

