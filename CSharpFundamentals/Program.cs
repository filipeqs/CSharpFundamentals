using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                var filipe = new Person("Filipe", "Silva");
                filipe.Introduce();

                var sum = Calculator.Add(1, 2);

                ArrayExplore();
                StringExplore();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void ArrayExplore()
        {
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (int num in numbers)
                Console.WriteLine(num);

             // Console.WriteLine(numbers[10]); Error
        }

        public static void StringExplore()
        {
            var name = "filipe";
            Console.WriteLine(name[2]);
            foreach (var letter in Convert.ToString(name))
                Console.WriteLine(letter);

            var numbers = new int[] { 1, 2, 3, 4 };
            var numberList = string.Join(",", numbers);
            Console.WriteLine(numberList);
        }
    }
}
