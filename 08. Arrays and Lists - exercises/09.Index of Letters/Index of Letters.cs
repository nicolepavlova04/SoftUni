using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] arr = new char[26];

            for (int i = 0; i <= word.Length - 1; i++)
            {
                char letterOfWord = word[i];
                for (int j = 0; j <= 25; j++)
                {
                    arr[j] = (char)('a' + j);
                    if (arr[j] == letterOfWord)
                    {
                        Console.WriteLine(letterOfWord + " -> " + j);
                    }

                }

            }
        }
    }
}
