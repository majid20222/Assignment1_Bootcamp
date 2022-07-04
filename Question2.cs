using System;

namespace Question2
{


    class Program
    {

        static void EvenOdd(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine(x + " is Even.");
            }
            else
            {
                Console.WriteLine(x + " is Odd.");
            }
        }

        static void Main(string[] args)
        {
            EvenOdd(2);
        }
    }
}