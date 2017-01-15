using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // 70 / 100 
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int maxFrequency = 0;
            int num = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                    if (maxFrequency == counter)
                    {
                        break;
                    }

                    if (maxFrequency < counter)
                    {
                        maxFrequency = counter;
                        num = numbers[i];
                    }


                    counter = 0;
                }
            }
            Console.WriteLine(num);
        }
    }
}
