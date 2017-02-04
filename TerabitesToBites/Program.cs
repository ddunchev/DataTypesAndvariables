using System;
using System.Numerics;

namespace TerabitesToBites
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:0.#}", (decimal)(input * 1024 * 1024 * 1024 * 1024 * 8));
        }
    }
}
