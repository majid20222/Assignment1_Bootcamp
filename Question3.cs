using System;

namespace Question3
{
    class Question3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number!");
            int first= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number!");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum = "+(first+second));
        }
    }
}
