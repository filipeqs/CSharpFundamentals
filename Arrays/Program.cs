using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var numbers = new int[] { 1, 4, 5, 2, 4, 2 };

                Console.WriteLine("Length {0}", numbers.Length);

                var index = Array.IndexOf(numbers, 2);
                Console.WriteLine("Index of 2 is {0}", index);

                Array.Clear(numbers, 0, 2);
                Console.WriteLine("Effect of Clear()");
                foreach (var item in numbers)
                    Console.Write(item + ", ");

                Console.WriteLine();

                var another = new int[3];
                Array.Copy(numbers, another, 3);
                Console.WriteLine("Effect of Copy()");
                foreach (var item in another)
                    Console.Write($"{item}, ");

                Console.WriteLine();

                Array.Sort(numbers);
                Console.WriteLine("Effect of Sort()");
                foreach (var item in numbers)
                    Console.Write($"{item}, ");

                Console.WriteLine();

                Array.Reverse(numbers);
                Console.WriteLine("Effect of Reverse()");
                foreach (var item in numbers)
                    Console.Write($"{item}, ");

                Console.WriteLine();

                ReverseString("Filipe");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void ReverseString(string str)
        {
            var strArr = str.ToCharArray();
            Array.Reverse(strArr);

            Console.WriteLine(string.Join("", strArr));
        }
    }
}
