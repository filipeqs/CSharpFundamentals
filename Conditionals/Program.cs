using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                QuestionFour();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        // 1- Write a program and ask the user to enter a number.
        // The number should be between 1 to 10. If the user enters a valid number,
        // display "Valid" on the console. Otherwise, display "Invalid".
        // (This logic is used a lot in applications where values entered into
        // input boxes need to be validated.)
        public static void QuestionOne()
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var inputNumber = Console.ReadLine();

            if (Convert.ToInt32(inputNumber) >= 0 &&
                Convert.ToInt32(inputNumber) <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        // 2- Write a program which takes two numbers from the console and
        // displays the maximum of the two.
        public static void QuestionTwo()
        {
            Console.WriteLine("Enter a number");
            var inputOne = Console.ReadLine();

            Console.WriteLine("Enter another number");
            var inputTwo = Console.ReadLine();

            var resultMessage = Convert.ToInt32(inputOne) >=
                Convert.ToInt32(inputTwo)
                ? inputOne : inputTwo;

            Console.WriteLine(resultMessage);
        }

        // 3- Write a program and ask the user to enter the width and height
        // of an image. Then tell if the image is landscape or portrait.
        public static void QuestionThree()
        {
            Console.WriteLine("Enter Eidth of the image");
            var width = Console.ReadLine();

            Console.WriteLine("Enter Height of the image");
            var height = Console.ReadLine();

            if (Convert.ToDecimal(width) > Convert.ToDecimal(height))
                Console.WriteLine("Image is Landscape");
            else
                Console.WriteLine("Image is Portrait");
        }

        // 4- Your job is to write a program for a speed camera. For simplicity,
        // ignore the details such as camera, sensors, etc and focus purely on
        // the logic. Write a program that asks the user to enter the speed
        // limit. Once set, the program asks for the speed of a car. If the user
        // enters a value less than the speed limit, program should display Ok
        // on the console. If the value is above the speed limit, the program
        // should calculate the number of demerit points. For every 5km/hr
        // above the speed limit, 1 demerit points should be incurred and
        // displayed on the console. If the number of demerit points is above
        // 12, the program should display License Suspended.
        public static void QuestionFour()
        {
            Console.WriteLine("Enter the speed limit");
            var speedLimit = Console.ReadLine();

            Console.WriteLine("Enter the speed of a car");
            var carSpeed = Console.ReadLine();

            if (Convert.ToInt32(carSpeed) > Convert.ToInt32(speedLimit))
            {
                var speedDif = Convert.ToInt32(carSpeed) - Convert.ToInt32(speedLimit);
                var demerit = speedDif / 5;

                if (demerit > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine(demerit);
            }
            else
                Console.WriteLine("Ok");

        }
    }
}
