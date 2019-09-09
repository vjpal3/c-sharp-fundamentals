using System;

namespace CsharpFundamentals.DateTimeExamples
{
    public class WorkingWithDateTime
    {
        public static void Calculate()
        {
            var dateTime = new DateTime(2019, 9, 8);
            var now = DateTime.Now;    // Now: 9 / 9 / 2019 6:00:48 AM
            Console.WriteLine("Now: " + now);
            Console.WriteLine("Hour: {0}, Minute: {1}", now.Hour, now.Minute);

            var today = DateTime.Today;
            Console.WriteLine("Today: " + today);   // Today: 9 / 9 / 2019 12:00:00 AM
            Console.WriteLine(now.AddDays(1)); //returns new DateTime object
            var yesterday = now.AddDays(-1);

            Console.WriteLine("ToLongDateString: " + now.ToLongDateString());
            Console.WriteLine("ToShortDateString: " + now.ToShortDateString());
            Console.WriteLine("ToLongTimeString: " + now.ToLongTimeString());
            Console.WriteLine("ToShortTimeString: " + now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
            ;
            /* ToLongDateString: Monday, September 9, 2019
            ToShortDateString: 9 / 9 / 2019
            ToLongTimeString: 3:56:21 PM
            ToShortTimeString: 3:56 PM
            2019-09-09 03:59 */

            // Creating Timespan
            var timespan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timespan);

            var timespan1 = TimeSpan.FromHours(1);  //static methods to create timespan
            Console.WriteLine(timespan1);

            var start = DateTime.Now;
            //var end = DateTime.Now.AddMinutes(20); // This adds a milisec component 
            var end = start.AddMinutes(20); 
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Timespan Properties
            Console.WriteLine("Minutes: " + timespan.Minutes); //returns Minutes component
            Console.WriteLine("Total Minutes: " + timespan.TotalMinutes); //Total Mints

            // DateTime & TimeSpan objects are immutable. But they can be modified
            Console.WriteLine("add example: " + timespan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("subtract example: " + timespan.Subtract(TimeSpan.FromMinutes(5)));

            //Parse - convert string to timespan object
            Console.WriteLine("Parse: " + TimeSpan.Parse("10:34:08"));
        }

    }
}
