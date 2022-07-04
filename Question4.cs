using System;

namespace Question4
{
    class Program
    {
        static bool ElementExist(int x, int [] nArray)
        {
            bool check = false;
            int i = 0;
            while (i<nArray.Length)
            {
                if (nArray[i] == x)
                {
                    check = true;
                    return check;
                }
                
                i++;
            }
            return check;  
        }
        static void Main(string[] args)
        {
           
            if (ElementExist(13, new [] { 1, 2, 3, 4, 5, 8, 9, 11 }))
            {
                Console.WriteLine("Yes Exist!");
            }
            else
            {
                Console.WriteLine("Not Exist!");
            }


            
        }
    }
}
