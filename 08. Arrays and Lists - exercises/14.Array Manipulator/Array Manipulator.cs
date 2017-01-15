using System;
using System.Linq;
using System.Collections.Generic;


public class Program
{
    static List<int> AddValuesAtPosition(List<int> nums, int pos, int elem)
    {
        nums.Insert(pos, elem);
        return nums;
    }

    static List<int> AddManyValues(List<int> nums, int pos, List<int> elem)
    {
        nums.InsertRange(pos, elem);

        return nums;
    }

    static List<int> ShiftFromPosition(List<int> nums, int pos)
    {
       

        int temp = 0;
        for (int i = 0; i < pos; i++)
        {
            temp = nums[0];
            nums.RemoveAt(0);
            nums.Add(temp);
        }
        return nums;

    }
    static void ContainsNumber(List<int> nums, int elem)
    {
        if (nums.Contains(elem))
        {
            Console.WriteLine(nums.IndexOf(elem));
        }
        else
        {
            Console.WriteLine("-1");
        }

    }

    static List<int> RemoveValueAtPosition(List<int> nums, int pos)
    {
        nums.RemoveAt(pos);
        return nums;
    }

    static List<int> SumPairs(List<int> nums)
    {
        List<int> sums = new List<int>();

        for (int i = 1; i < nums.Count; i += 2)
        {
            sums.Add(nums[i - 1] + nums[i]);
        }

        if (nums.Count % 2 == 1)
        {
            sums.Add(nums[nums.Count - 1]);
        }

        return sums;
    }

    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        string command = Console.ReadLine().ToLower();
        List<int> result = new List<int>();

        while (command != "print")
        {
            string[] actions = command.Split(' ');



            if (actions[0] == "add")
            {
                int index = int.Parse(actions[1]);
                int element = int.Parse(actions[2]);
                result = AddValuesAtPosition(numbers, index, element);

            }
            else if (actions[0] == "addmany")
            {
                int index = int.Parse(actions[1]);
                List<int> values = new List<int>();

                for (int i = 2; i < actions.Length; i++)
                {
                    values.Add(int.Parse(actions[i]));
                }

                result = AddManyValues(numbers, index, values);
            }
            else if (actions[0] == "contains")
            {
                int element = int.Parse(actions[1]);

                ContainsNumber(numbers, element);
                result = numbers;

            }
            else if (actions[0] == "remove")
            {
                int index = int.Parse(actions[1]);

                result = RemoveValueAtPosition(numbers, index);
            }
            else if (actions[0] == "shift")
            {
                int positions = int.Parse(actions[1]);
                result = ShiftFromPosition(numbers, positions);
            }
            else if (actions[0] == "sumpairs")
            {
                result = SumPairs(numbers);
            }

            numbers = result;
            command = Console.ReadLine().ToLower();
        }

        Console.WriteLine("[{0}]", string.Join(", ", result));
    }
}