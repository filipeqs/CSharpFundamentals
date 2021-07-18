using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class Exercises
    {
        public static void Run()
        {
            QuestionFive();
        }

        // 1- Write a program and ask the user to enter a few numbers separated
        // by a hyphen. Work out if the numbers are consecutive. For example,
        // if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message:
        // "Consecutive"; otherwise, display "Not Consecutive".
        public static void QuestionOne()
        {
            Console.WriteLine("Enter numbers separated by hyphen. (e.g. 5-6-7-8-9)");
            var input = Console.ReadLine();

            var numbers = input.Split("-");
            int firstValue = Convert.ToInt32(numbers[0]);
            var consecutive = true;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) > firstValue &&
                    Convert.ToInt32(numbers[i]) - i != firstValue)
                {
                    consecutive = false;
                    break;
                }
                else if (Convert.ToInt32(numbers[i]) < firstValue &&
                    Convert.ToInt32(numbers[i]) + i != firstValue)
                {
                    consecutive = false;
                    break;
                }
            }

            if (consecutive)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");
        }

        // 2- Write a program and ask the user to enter a few numbers separated
        // by a hyphen. If the user simply presses Enter, without supplying an
        // input, exit immediately; otherwise, check to see if there are
        // duplicates. If so, display "Duplicate" on the console.
        public static void QuestionTwo()
        {
            Console.WriteLine("Enter numbers separated by hyphen. (e.g. 5-6-7-8-9)");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                Environment.Exit(0);

            var listNumbers = new List<int>();
            var numbers = input.Split("-");
            foreach (var number in numbers)
            {
                if (listNumbers.Contains(Convert.ToInt32(number)))
                {
                    Console.WriteLine("Duplicate");
                    break;
                }

                listNumbers.Add(Convert.ToInt32(number));
            }
        }

        // 3- Write a program and ask the user to enter a time value in the
        // 24-hour time format (e.g. 19:00). A valid time should be between
        // 00:00 and 23:59. If the time is valid, display "Ok"; otherwise,
        // display "Invalid Time". If the user doesn't provide any values,
        // consider it as invalid time.
        public static void QuestionThree()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format " +
                "(e.g. 19:00)");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                Environment.Exit(0);
            }

            var time = input.Split(":");
            var hour = Convert.ToInt32(time[0]);
            var minutes = Convert.ToInt32(time[1]);

            if (hour < 0 || hour > 24)
                Console.WriteLine("Invalid Time");

            if (minutes < 0 || minutes > 59)
                Console.WriteLine("Invalid Time");
        }

        // 4- Write a program and ask the user to enter a few words separated
        // by a space. Use the words to create a variable name with PascalCase.
        // For example, if the user types: "number of students", display
        // "NumberOfStudents". Make sure that the program is not dependent on
        // the input. So, if the user types "NUMBER OF STUDENTS", the program
        // should still display "NumberOfStudents".
        public static void QuestionFour()
        {
            Console.WriteLine("Enter words separated by space");
            var input = Console.ReadLine();

            var words = input.Split(" ");
            var builder = new StringBuilder();
            foreach (var word in words)
                builder.Append(word.Substring(0, 1).ToUpper() +
                    word.Substring(1).ToLower());

            Console.WriteLine(builder);
        }

        // 5- Write a program and ask the user to enter an English word. Count
        // the number of vowels (a, e, o, u, i) in the word. So, if the user
        // enters "inadequate", the program should display 6 on the console.
        public static void QuestionFive()
        {
            Console.WriteLine("Enter and English word");
            var input = Console.ReadLine();

            var count = 0;
            var charactes = input.ToLower().ToCharArray();
            foreach (var character in charactes)
            {
                if (IsVowels(character))
                    count++;
            }

            Console.WriteLine($"Number of vowels: {count}");
        }

        public static bool IsVowels(char letter) =>
                (letter == 'a' ||
                letter == 'e' ||
                letter == 'i' ||
                letter == 'o' ||
                letter == 'u');
    }
}
