using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
       
        static int GetInteger(int firstNumber, int secondNumber)
        {
            int result = 0;
            if (firstNumber > secondNumber)
            {
                result = firstNumber;
            }
            else
            {
                result = secondNumber;
            }
            return result;
        }
        
        static char GetChar(char firstChar, char secondChar)
        {
            char result = ' ';
            if (firstChar > secondChar)
            {
                result = firstChar;
            }
            else
            {
                result = secondChar;
            }
            return result;
        }
        
        static string GetString(string firstString, string secondString)
        {
            string result = "";
            if (firstString.CompareTo(secondString) >= 0)
            {
                result = firstString;
            }
            else
            {
                result = secondString;
            }
            return result;
        }
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int max = GetInteger(firstNumber, secondNumber);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char max = GetChar(firstChar, secondChar);
                Console.WriteLine(max);
            }
            else
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string max = GetString(firstString, secondString);
                Console.WriteLine(max);
            }

        }
    }
}
