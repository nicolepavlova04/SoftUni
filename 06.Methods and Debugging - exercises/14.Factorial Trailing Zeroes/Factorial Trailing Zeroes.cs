using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class factorial
    {
        static BigInteger GetFactoial(BigInteger number)
        {
            BigInteger result = 0;
            BigInteger factorial = 1;
            for (BigInteger i = 0; i < number; i++)
            {
                result = number - i;
                factorial *= result;
            }
            return factorial;
        }
        static BigInteger GetTrailingZeros(BigInteger number)
        {

            BigInteger num = 0;
            BigInteger sum = 0;
            do
            {
                num += (number % 10);
                number /= 10;
                if (num == 0)
                {
                    sum++;
                }
                else
                {
                    break;
                }


            } while (number > 0);
            return sum;
        }
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = GetFactoial(number);
            Console.WriteLine(GetTrailingZeros(factorial));
        }
    }
}
