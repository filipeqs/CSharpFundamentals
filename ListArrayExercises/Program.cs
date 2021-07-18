using System;
using System.Collections.Generic;

namespace ListArrayExercises
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
                Console.WriteLine(ex);
            }
        }

        // 1- When you post a message on Facebook, depending on the number of
        // people who like your post, Facebook displays different information.

        // If no one likes your post, it doesn't display anything.
        // If only one person likes your post, it displays: [Friend's Name]
        // likes your post.
        // If two people like your post, it displays: [Friend 1] and [Friend 2]
        // like your post.
        // If more than two people like your post, it displays: [Friend 1],
        // [Friend 2] and [Number of Other People] others like your post.

        // Write a program and continuously ask the user to enter different
        // names, until the user presses Enter (without supplying a name).
        // Depending on the number of names provided, display a message based
        // on the above pattern.
        public static void QuestionOne()
        {
            var likes = new List<string>();

            while(true)
            {
                Console.WriteLine("Enter a person name");
                var nameLiked = Console.ReadLine();
                if (nameLiked == "")
                    break;

                likes.Add(nameLiked);
            }

            var likesSize = likes.Count;

            if (likesSize == 1)
                Console.WriteLine($"{likes[0]} likes you post");
            else if (likesSize == 2)
                Console.WriteLine($"{likes[0]} and {likes[1]} likes you post");
            else if (likesSize > 2)
            {
                Console.WriteLine($"{likes[0]} and {likes[1]} and {likesSize - 2} " +
                    $"others likes you post");
            }
        }

        // 2- Write a program and ask the user to enter their name. Use an
        // array to reverse the name and then store the result in a new string.
        // Display the reversed name on the console.
        public static void QuestionTwo()
        {
            Console.WriteLine("Enter your name");
            var name = Console.ReadLine();

            var nameArr = name.ToCharArray();

            Array.Reverse(nameArr);

            var reversedName = string.Join("", nameArr);
            Console.WriteLine(reversedName);
        }

        // 3- Write a program and ask the user to enter 5 numbers. If a number
        // has been previously entered, display an error message and ask the
        // user to re-try. Once the user successfully enters 5 unique numbers,
        // sort them and display the result on the console.
        public static void QuestionThree()
        {
            var numbers = new List<int>();

            while(numbers.Count < 5)
            {
                Console.WriteLine("Enter number");
                var input = Console.ReadLine();
                if (numbers.Contains(Convert.ToInt32(input)))
                {
                    Console.WriteLine("try again");
                    continue;
                }

                numbers.Add(Convert.ToInt32(input));
            }

            numbers.Sort();
            foreach (var number in numbers)
                Console.Write($"{number}, ");
        }

        // 4- Write a program and ask the user to continuously enter a number
        // or type "Quit" to exit. The list of numbers may include duplicates.
        // Display the unique numbers that the user has entered.
        public static void QuestionFour()
        {
            var numbers = new List<int>();

            while(true)
            {
                Console.WriteLine("Enter a number, enter Quit to stop");
                var input = Console.ReadLine();

                if (input.ToLower() == "Quit".ToLower())
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniqueNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                    uniqueNumbers.Add(number);
            }

            foreach (var number in uniqueNumbers)
                Console.Write($"{number}, ");
        }

        // 5- Write a program and ask the user to supply a list of comma
        // separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or
        // includes less than 5 numbers, display "Invalid List" and ask the
        // user to re-try; otherwise, display the 3 smallest numbers in the
        // list.
        public static void QuestionFive()
        {
            var numbers = new List<int>();

            while(true)
            {
                Console.WriteLine("Enter list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
                var input = Console.ReadLine();

                var inputArr = input.Split(",");
                if (inputArr.Length > 5)
                {
                    foreach (var item in inputArr)
                        numbers.Add(Convert.ToInt32(item.Trim()));

                    break;
                }

                Console.WriteLine("Re-try");
            }

            numbers.Sort();
            for (int i = 0; i < 3; i++)
                Console.Write($"{numbers[i]}, ");
        }
    }
}
