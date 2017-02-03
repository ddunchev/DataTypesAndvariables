using System;

namespace PracticeIntegerNumbers
{
    class program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine()); ;
            int temp = 0;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);
#if debug
			Console.ReadKey();
#endif
        }
    }
}