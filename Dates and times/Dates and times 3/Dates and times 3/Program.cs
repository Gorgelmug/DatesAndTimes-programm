using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates_and_times_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nextyear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            TimeSpan duration = nextyear - DateTime.Today;
            Console.WriteLine($"There are {duration.TotalDays} days left in the year");
            Console.ReadKey();
        }
    }
}
