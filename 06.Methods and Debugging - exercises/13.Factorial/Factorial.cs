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
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(GetFactoial(number));
        }
    }
}
