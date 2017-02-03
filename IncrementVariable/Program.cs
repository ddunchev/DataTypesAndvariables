using System;

namespace IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {

            int incrementTimes = int.Parse(Console.ReadLine());
            byte num = 0;
            int count = 0;

            for (int i = 0; i < incrementTimes; i++)
            {
                num++;
                if (num == 0) count++;
            }

            Console.WriteLine(num);

            if (count > 0) Console.WriteLine("Overflowed {0} times", count);
        }
    }
}
