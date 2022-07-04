using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            while (start < 6)
            {
                int mid = 0;
                while (mid != start)
                {
                    Console.Write(mid + 1);
                    mid++;

                }
                Console.WriteLine("");
                start++;
            }
        }
    }
}
