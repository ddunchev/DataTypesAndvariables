using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingAtLightSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            decimal lightYear = 9450000000000;

            decimal sec = lightYear * input / 300000;

            decimal min = sec / 60;

            decimal hour = min / 60;

            decimal days = hour / 24;

            decimal weeks = days / 7;

            Console.WriteLine($"{Math.Truncate(weeks)} weeks");

            Console.WriteLine($"{Math.Truncate(days % 7)} days");

            Console.WriteLine($"{Math.Truncate(hour % 24)} hours");

            Console.WriteLine($"{Math.Truncate(min % 60)} minutes");

            Console.WriteLine($"{Math.Truncate(sec % 60)} seconds");
        }
    }
}
