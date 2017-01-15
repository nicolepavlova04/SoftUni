using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersAsString = Console.ReadLine().ToLower().Split(' ');
            Dictionary<string, int> wordsByCount = new Dictionary<string, int>();
            for (int i = 0; i < numbersAsString.Length; i++)
            {
                if (wordsByCount.ContainsKey(numbersAsString[i]))
                {
                    wordsByCount[numbersAsString[i]] += 1;
                }
                else
                {
                    wordsByCount[numbersAsString[i]] = 1;
                }
            }
            List<string> words = new List<string>();
            foreach (string word in wordsByCount.Keys)
            {
                if (wordsByCount[word] % 2 == 1)
                {
                    words.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", words));
        }
    }
}
