using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static int[] Rotation(int[] input)
        {
            int[] rotated = new int[input.Length];
            rotated[0] = input[input.Length - 1];

            for (int i = 0; i < rotated.Length - 1; i++)
            {
                rotated[0] = input[input.Length - 1];
                rotated[(i + 1)] = input[i];
            }
            return rotated;
        }
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[input.Length];
            while (rotations > 0)
            {

                int[] rotation = Rotation(input);

                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = sum[i] + rotation[i];
                }
                rotations--;
                input = rotation;
            }
            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
