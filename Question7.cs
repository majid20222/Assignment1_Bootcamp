using System;

namespace Question7
{
    class Program
    {
        static int [] OddElems(int [] givenArray)
        {
            int n = 1;
            int m = 0;
            int[] newArr = new int[givenArray.Length/2];

            while (n<givenArray.Length)
            {
                
                newArr[m] = givenArray[n];
                n += 2;
                m++;
            }

           
            return newArr;
        }
        static void Main(string[] args)
        {
            int[] CheckArray = OddElems(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11 });

            foreach (int item in CheckArray)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
