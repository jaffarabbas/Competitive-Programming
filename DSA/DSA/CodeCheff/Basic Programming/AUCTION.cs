﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class AUCTION
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                if (l[0] > l[1] && l[0] > l[2])
                {
                    Console.WriteLine("Alice");
                }
                else if (l[1] > l[0] && l[1] > l[2])
                {
                    Console.WriteLine("Bob");
                }
                else if (l[2] > l[0] && l[2] > l[1])
                {
                    Console.WriteLine("Charlie");
                }
            }
        }
    }
}
