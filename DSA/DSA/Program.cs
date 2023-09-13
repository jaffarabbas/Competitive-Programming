
using System;

namespace DSA 
{
    internal class Program
    {
        public static void Main()
        {
            long t = long.Parse(Console.ReadLine());
            long len = 0;
            while (t > 0)
            {
                t /= 10;
                len++;
            }
            if(len > 3)
            {
                Console.WriteLine("More than 3 digits");
            }
            else
            {
                Console.WriteLine(len);
            }
            //int t = int.Parse(Console.ReadLine());
            //while ((t--) > 0)
            //{
            //    int c = int.Parse(Console.ReadLine());
            //    string[] lines = Console.ReadLine().Split(" ");
            //    string[] lines2 = Console.ReadLine().Split(" ");
            //    int[] a1 = Array.ConvertAll(lines, int.Parse);
            //    int[] a2 = Array.ConvertAll(lines2, int.Parse);
            //    int count = 0;
            //    for (int i = 0; i < c; i++)
            //    {
            //        int h1 = 0, h2 = 0;
            //        if (a1[i] != a2[i])
            //        {
            //            if (a1[i] * 2 > a2[i])
            //            {
            //                h1++;
            //            }
            //            if (a2[i] > a1[i] * 2)
            //            {
            //                h2++;
            //            }
            //        }
            //        else
            //        {
            //            h1++;h2++;
            //        }
            //        if(h1 == h2)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine(count);
            //}
        }   
    }
}