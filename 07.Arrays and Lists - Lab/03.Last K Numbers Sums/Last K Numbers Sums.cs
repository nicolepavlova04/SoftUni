﻿using System;
namespace LastKNumbersSums
{
    public class LastKNumbersSums
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] numbers = new long[n];
            numbers[0] = 1;
            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = i - 1; j >= 0 && j >= i - k; j--)
                {
                    sum += numbers[j];
                }
                numbers[i] = sum;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}