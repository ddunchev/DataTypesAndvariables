using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine());

            for (byte i = 0; i <= number; i++)
            {
                try
                {
                    Console.WriteLine(i);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
