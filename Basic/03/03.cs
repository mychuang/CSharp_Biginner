using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DateTime {
    class Program {

        static void Main(string[] args) {

            var currentTime = DateTime.Now; // current time
            Console.WriteLine($"{nameof(currentTime)}: {currentTime}");

            var today = DateTime.Today; // current date - time is midnight
            Console.WriteLine($"{nameof(today)}: {today}");

            var someDate = new DateTime(2016,7,1);
            Console.WriteLine($"{nameof(someDate)}: {someDate}");

            var someMoment = new DateTime(2016,7,1,8,0,0);
            Console.WriteLine($"{nameof(someMoment)}: {someMoment}");

            var tomorrow = DateTime.Today.AddDays(1);
            Console.WriteLine($"{nameof(tomorrow)}: {tomorrow}");

            var yesterday = DateTime.Today.AddDays(-1);
            Console.WriteLine($"{nameof(yesterday)}: {yesterday}");

            var someDay = DateTime.Parse("7/1/2016");
            Console.WriteLine($"{nameof(someDay)}: {someDay}");

            Console.WriteLine("====================================");

            var someTime = new DateTime(2016,7,1,11,10,9);
            Console.WriteLine($"{nameof(someTime)}: {someTime}");

            int year = someTime.Year;
            Console.WriteLine($"{nameof(year)}: {year}");

            int month = someTime.Month;
            Console.WriteLine($"{nameof(month)}: {month}");

            int day = someTime.Day;
            Console.WriteLine($"{nameof(day)}: {day}");

            int hour = someTime.Hour;
            Console.WriteLine($"{nameof(hour)}: {hour}");

            int minute = someTime.Minute;
            Console.WriteLine($"{nameof(minute)}: {minute}");

            int second = someTime.Second;
            Console.WriteLine($"{nameof(second)}: {second}");

            Console.WriteLine("====================================");

            DateTime nextYear = new DateTime(DateTime.Today.Year+1, 1, 1);

            TimeSpan duration = nextYear - DateTime.Today;

            Console.WriteLine($"There are {duration.TotalDays} days left in the year");

            Console.ReadKey();
        }
    }
}
