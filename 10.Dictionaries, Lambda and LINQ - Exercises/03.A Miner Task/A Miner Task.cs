using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> dict = new Dictionary<string, decimal>();
            string input = Console.ReadLine();
            while (input != "stop")
            {
                decimal amount = decimal.Parse(Console.ReadLine());
                
                if (dict.ContainsKey(input))
                {
                    dict[input] += amount;
                }
                
                else
                {
                    dict[input] = amount;
                }
                input = Console.ReadLine();
            }
                foreach (string key in dict.Keys)
                {
                    Console.WriteLine($"{key} -> {dict[key]}");
                }
        }
    }
}
