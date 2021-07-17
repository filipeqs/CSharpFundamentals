using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var numbers = new List<int>() { 1, 2 };
                numbers.Add(1);
                numbers.AddRange(new int[] { 5, 6 });

                foreach (var number in numbers)
                    Console.Write($"{number}, ");

                Console.WriteLine();

                var index = numbers.IndexOf(1);
                Console.WriteLine($"First index of 1: {index}");

                var lastIndex = numbers.LastIndexOf(1);
                Console.WriteLine($"Last index of 1: {lastIndex}");

                var count = numbers.Count;
                Console.WriteLine("Count: {0}", count);

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == 1)
                        numbers.Remove(numbers[i]);
                }
                Console.WriteLine("After removing all 1");
                foreach (var number in numbers)
                    Console.Write($"{number}, ");

                Console.WriteLine();

                numbers.Clear();
                Console.WriteLine($"Effect of Clear(), Count: {numbers.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
