using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + now);

            // Creating a specific date and time
            DateTime specificDate = new DateTime(2024, 11, 5, 14, 30, 0);
            Console.WriteLine("Specific Date and Time: " + specificDate);

            // Formatting DateTime
            Console.WriteLine("Formatted Date: " + now.ToString("yyyy-MM-dd"));
            Console.WriteLine("Formatted Time: " + now.ToString("HH:mm:ss"));
            Console.WriteLine("Full Date and Time: " + now.ToString("F"));

            // Adding days, months, and years
            DateTime tomorrow = now.AddDays(1);
            DateTime nextMonth = now.AddMonths(1);
            DateTime nextYear = now.AddYears(1);
            Console.WriteLine("Tomorrow: " + tomorrow);
            Console.WriteLine("Next Month: " + nextMonth);
            Console.WriteLine("Next Year: " + nextYear);

            // Subtracting days
            DateTime yesterday = now.AddDays(-1);
            Console.WriteLine("Yesterday: " + yesterday);

            // Difference between two dates
            TimeSpan difference = specificDate - now;
            Console.WriteLine("Difference between specific date and now: " + difference.Days + " days");

            // Check if a date is in the future
            bool isFutureDate = specificDate > now;
            Console.WriteLine("Is the specific date in the future? " + isFutureDate);

            // Getting day, month, and year
            Console.WriteLine("Day: " + now.Day);
            Console.WriteLine("Month: " + now.Month);
            Console.WriteLine("Year: " + now.Year);

            // Getting the day of the week
            Console.WriteLine("Day of the Week: " + now.DayOfWeek);
        }
    }
}

