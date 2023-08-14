﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeForces._1760
{
    internal class C
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int l = int.Parse(Console.ReadLine());
                string[] lines = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(lines, int.Parse);
                int[] sorter = Array.ConvertAll(lines, int.Parse);
                Array.Sort(sorter);
                for (int i = 0; i < l; i++)
                {
                    if (arr[i] != sorter[sorter.Length - 1])
                    {
                        arr[i] -= sorter[sorter.Length - 1];
                    }
                    else
                    {
                        arr[i] -= sorter[sorter.Length - 2];
                    }
                }
                foreach (var item in arr)
                {
                    Console.Write(item+" ");
                }
            }
        }
    }
}
