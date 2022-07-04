using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number whose Table is to be generated!");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number upto which Table is to be generated!");
            int mNumber = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            Console.WriteLine(" ");
            while (n<=mNumber)
            {
               
                Console.WriteLine(userNumber+"*"+n+"="+(userNumber*n));
                n++;
            }
        }
    }
}
