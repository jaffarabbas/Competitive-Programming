using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CS2023_STK
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int t2 = int.Parse(Console.ReadLine());
                int[] l1 = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int[] l2 = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int count = 0,count2 = 0;
                int max = 0, max2 = 0;
                for (int i = 0; i < t2; i++)
                {
                    if (l1[i] != 0)
                    {
                        count++;
                        if(max < count)
                        {
                            max = count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                for (int i = 0; i < t2; i++)
                {
                    if (l2[i] != 0)
                    {
                        count2++;
                        if (max2 < count2)
                        {
                            max2 = count2;
                        }
                    }
                    else
                    {
                        count2 = 0;
                    }
                }
                if (max > max2)
                {
                    Console.WriteLine("Om");
                }else if(max == max2)
                {
                    Console.WriteLine("Draw");
                }
                else
                {
                    Console.WriteLine("Addy");
                }
            }
        }
    }
}
