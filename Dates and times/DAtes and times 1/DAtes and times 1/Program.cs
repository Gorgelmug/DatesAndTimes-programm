using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAtes_and_times_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentTime = DateTime.Now;                         //current time
            var today = DateTime.Today;                             //current date - time is midnight
            var someDate = new DateTime(2017, 8, 16);               //current date, midnight
            var someMoment = new DateTime(2017, 8, 16, 11,6,0);     //current date and time
            var tomorrow = DateTime.Today.AddDays(1);               //tomorrow
            var yesterday = DateTime.Today.AddDays(-1);             //yesterday
            var someday = DateTime.Parse("8/1/2016");
            Console.WriteLine(currentTime);
            Console.WriteLine(today);
            Console.WriteLine(someDate);
            Console.WriteLine(someMoment);
            Console.WriteLine(tomorrow);
            Console.WriteLine(yesterday);
            Console.WriteLine(someday);
            Console.ReadKey();           
        }
    }
}
