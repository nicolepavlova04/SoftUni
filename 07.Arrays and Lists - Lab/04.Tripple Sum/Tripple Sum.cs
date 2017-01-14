using System;
using System.Linq;

public class Program
{
    public static void Main()
    {

        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool contains = false;

        for (int a = 0; a < numbers.Length; a++)
        {
            for (int b = a + 1; b < numbers.Length; b++)
            {

                for (int c = 0; c < numbers.Length; c++)
                {
                    if (numbers[a] + numbers[b] == numbers[c])
                    {
                        Console.WriteLine("{0} + {1} == {2}", numbers[a], numbers[b], numbers[c]);
                        contains = true;
                        break;
                    }
                }

            }

        }

        if (!contains)
        {
            Console.WriteLine("No");
        }
    }
}