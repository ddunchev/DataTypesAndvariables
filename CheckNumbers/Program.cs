using System;
//using System.Math;
namespace PracticeIntegerNumbers
{
    class program
    {
        static void Main()
        {
            string a = Console.ReadLine();
            int intNum;
            float floatNum;
            if (int.TryParse(a, out intNum)) Console.WriteLine(intNum);
            else if (float.TryParse(a, out floatNum)) Console.WriteLine(Math.Round(floatNum));

#if debug
			Console.ReadKey();
#endif
        }
    }
}