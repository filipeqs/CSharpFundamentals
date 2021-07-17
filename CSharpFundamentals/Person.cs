using System;
namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FirstName}");
        }
    }
}
