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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void StringExplore()
        {
            var name = "filipe";
            Console.WriteLine(name[2]);
            foreach (var letter in Convert.ToString(name))
                Console.WriteLine(letter);
            var splitname = name.Split("");
            Console.WriteLine(splitname);

            var numbers = new int[] { 1, 2, 3, 4 };
            var numberList = string.Join(",", numbers);
            Console.WriteLine(numberList);
        }

        public static void ArrayExplore()
        {
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (int num in numbers)
                Console.WriteLine(num);

             // Console.WriteLine(numbers[10]); Error
        }

        public static void EnumExplore()
        {
            Console.WriteLine((int)ShippingMethods.Express);
            var methodId = 3;
            Console.WriteLine((ShippingMethods)methodId);

            var methodName = "Express";
            var shippingMethod = (ShippingMethods)Enum.Parse(typeof(ShippingMethods), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
