using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void PrintFirstAndLastRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintMiddleRows(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintFirstAndLastRow(n);
            for (int i = 1; i <= n - 2; i++)
            {
                PrintMiddleRows(n);
            }
            PrintFirstAndLastRow(n);
        }
    }
}
