using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var filipe = new Person("Filipe", "Silva");
            filipe.Introduce();

            Console.WriteLine(Calculator.Add(1,2));
        }
    }
}
