using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOfTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal proximaCentauri = 4.22m;
            decimal milkyWay = 26000m;
            decimal diameterOfMilkyWay = 100000m;
            decimal toTheEdge = 46500000000m;

            Console.WriteLine($"{proximaCentauri * 9450000000000:0.##e+000}");
            Console.WriteLine($"{milkyWay * 9450000000000:0.##e+000}");
            Console.WriteLine($"{diameterOfMilkyWay * 9450000000000:0.##e+000}");
            Console.WriteLine($"{toTheEdge * 9450000000000:0.##e+000}");




        }
    }
}
