using System;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("ToLongDateString(): " + now.ToLongDateString());
            Console.WriteLine("ToShortDateString(): " + now.ToShortDateString());
            Console.WriteLine("ToLongTimeString(): " + now.ToLongTimeString());
            Console.WriteLine("ToShortTimeString(): " + now.ToShortTimeString());
            Console.WriteLine("ToString():" + now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
