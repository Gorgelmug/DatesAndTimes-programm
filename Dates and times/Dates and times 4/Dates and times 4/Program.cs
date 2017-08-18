using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates_and_times_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DateOfBirth = new DateTime(1979, 1, 21, 12, 30, 0);                     //My Birtday and aprox time
            var ThisDay = DateTime.Today;
            TimeSpan LifeSpan = ThisDay - DateOfBirth;

            Console.WriteLine($"I am {LifeSpan.TotalDays / 365} years old!");               //time in years i am a live
            Console.WriteLine($"In months that will be {LifeSpan.TotalDays * 12}");         //in months etc....
            Console.WriteLine($"In weeks that is {LifeSpan.TotalDays * 52}");
            Console.WriteLine($"I am watchin the world for {LifeSpan.TotalDays} days now");
            Console.WriteLine($"In minutes that is {(LifeSpan.TotalDays * 365)*60}");
            Console.WriteLine($"in seconds that will be {(LifeSpan.TotalDays * 60) * 60}");

            Console.ReadKey();
        }
    }
}
