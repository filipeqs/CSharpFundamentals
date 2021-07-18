using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Filipe Silva ";
            Console.WriteLine($"Trim: '{fullName.Trim()}'");
            Console.WriteLine($"ToUpper: '{fullName.Trim().ToUpper()}'");

            var index = fullName.IndexOf(" ");
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}");

            var names = fullName.Split(" ");
            Console.WriteLine($"First Name: {names[0]}, Last Name: {names[1]}");

            Console.WriteLine("Replace Silva with Queiroz: " + fullName.Replace("Silva", "Queiroz"));
            Console.WriteLine("Replace all 'i' with 'a': " + fullName.Replace("i", "a"));

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "28";
            var age = Convert.ToByte(str);
            Console.WriteLine("Age: " + age);

            float price = 29.95f;
            Console.WriteLine("Price: " + price.ToString("C"));

            var setence = "this is a really really really really long text";
            var summary = StringUtils.Summarise(setence);
            Console.WriteLine(summary);

            Builder.Run();
        }
    }
}
