﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class WATERFILLING
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                if ((l[0] == 0 && l[1] == 0) || (l[2] == 0 && l[1] == 0) || l[2] == 0 && l[0] == 0)
                {
                    Console.WriteLine("Water filling time");
                }
                else
                {
                    Console.WriteLine("Not now");
                }
            }
        }
    }
}
