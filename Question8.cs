using System;

namespace Question8
{
    class Program
    {
        static bool isPrime(int x)
        {
            bool v = false;
            int y = x;
            while (y!=2)
            {
                y--;
                if (x % y == 0)
                {
                    v = true;
                }
               
            }
            return v;
        }
        static void Main(string[] args)
        {
            if (isPrime(4))
            {
                Console.WriteLine("No Prime");
            }
            else
            {
                Console.WriteLine("Yes Prime");
            }
        }
    }
}
