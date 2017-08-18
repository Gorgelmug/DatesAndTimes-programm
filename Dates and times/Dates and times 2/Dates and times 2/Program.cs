using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates_and_times_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var someTime = new DateTime(2017, 8, 16, 11, 23, 01);       //16 august 2017 11:23.01
            int year = someTime.Year;                                   //2017
            int month = someTime.Month;                                 //august or 8
            int day = someTime.Day;                                     //16
            int hour = someTime.Hour;                                   //11
            int minute = someTime.Minute;                               //23
            int second = someTime.Second;                                //01
            Console.WriteLine(someTime);                                //16 august 2017 11:23.01
            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(day);
            Console.WriteLine(hour);
            Console.WriteLine(minute);
            Console.WriteLine(second);
            Console.ReadKey();

        }
    }
}
