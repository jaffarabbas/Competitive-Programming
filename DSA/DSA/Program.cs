
using System;

namespace DSA 
{
    internal class Program
    {
        public static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int x = int.Parse(Console.ReadLine());
                int c = 0;
                if (x != 50)
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        if (x > 50)
                        {
                            x -= 3;
                            c++;
                        }
                        if (x < 50)
                        {
                            x += 2;
                            c++;
                        }
                        if (x == 50)
                        {
                            break;
                        }
                    }
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(0);
                }
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