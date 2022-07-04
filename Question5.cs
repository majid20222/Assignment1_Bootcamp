using System;

namespace Question5
{
    class Program
    {
        static int Largest(int [] uArray)
        {
            int n = 0;
            int large = 0;
            while (n!=uArray.Length)
            {
                if (uArray[n] > large)
                {
                    large = uArray[n];
                } 
                n++;
            }
            return large;
        }
        static void Main(string[] args)
        {
            int l=Largest(new[] {1,2,100,4,5,6,700});
            Console.WriteLine(l);
        }
    }
}
