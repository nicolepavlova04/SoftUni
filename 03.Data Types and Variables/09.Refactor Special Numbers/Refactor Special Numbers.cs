using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int digits = i;
                int sum = 0;

                while (digits > 0)
                {
                    sum += (digits % 10);
                    digits /= 10;
                }
                bool special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, special);
            }

        }
    }
}
