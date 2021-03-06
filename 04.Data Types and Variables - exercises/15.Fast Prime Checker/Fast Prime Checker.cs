﻿using System;
namespace FastPrimeCheckerRefactor
{
    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= num; currentNumber++)
            {
                bool isPrime = true;
                for (int devider = 2; devider <= Math.Sqrt(currentNumber); devider++)
                {
                    if (currentNumber % devider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }
        }
    }
}
