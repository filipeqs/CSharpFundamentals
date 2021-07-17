using System;

namespace InterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                QuestionFive();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        // 1- Write a program to count how many numbers between 1 and 100 are
        // divisible by 3 with no remainder. Display the count on the console.
        public static void QuestionOne()
        {
            var count = 0;
            for (var i = 1; i<= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(count);
        }

        // 2- Write a program and continuously ask the user to enter a number
        // or "ok" to exit. Calculate the sum of all the previously entered
        // numbers and display it on the console.
        public static void QuestionTwo()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter number to calculer SUM, Enter OK to calculate");
                var input = Console.ReadLine();

                if (input.ToLower() == "OK".ToLower())
                    break;

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine(sum);
        }

        // 3- Write a program and ask the user to enter a number. Compute the
        // factorial of the number and print it on the console. For example,
        // if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1
        // and display it as 5! = 120.
        public static void QuestionThree()
        {
            Console.WriteLine("Enter a number");
            var number = Console.ReadLine();

            var factorial = Convert.ToInt32(number);
            for (int i = Convert.ToInt32(number) - 1; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"{number}! = {factorial}");
        }

        // 4- Write a program that picks a random number between 1 and 10.
        // Give the user 4 chances to guess the number. If the user guesses the
        // number, display “You won"; otherwise, display “You lost". (To make
        // sure the program is behaving correctly, you can display the secret
        // number on the console first.)
        public static void QuestionFour()
        {
            var randomNumber = new Random().Next(1, 10);
            Console.WriteLine(randomNumber);

            Console.WriteLine("Guess a number between 1 and 10");

            var numberGuesses = 4;
            while (numberGuesses >= 0)
            {
                if (numberGuesses == 0)
                {
                    Console.WriteLine("You lost!");
                    break;
                }

                var input = Console.ReadLine();

                if (Convert.ToInt32(input) == randomNumber)
                {
                    Console.WriteLine("You Won!");
                    break;
                }

                Console.WriteLine("Try Again");
                numberGuesses--;
            }
        }

        // 5- Write a program and ask the user to enter a series of numbers
        // separated by comma. Find the maximum of the numbers and display it
        // on the console. For example, if the user enters “5, 3, 8, 1, 4", the
        // program should display 8.
        public static void QuestionFive()
        {
            Console.WriteLine("Write numbers separated by \",\"");
            var input = Console.ReadLine();

            var arrayInput = input.Split(",");

            int max = 0;
            foreach (var value in arrayInput)
            {
                if (Convert.ToInt32(value) > max)
                    max = Convert.ToInt32(value);
            }

            Console.WriteLine(max);
        }
    }
}
