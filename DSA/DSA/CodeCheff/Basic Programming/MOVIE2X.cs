﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class MOVIE2X
    {
        public static void func()
        {
            int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Console.WriteLine((l[1] / 2) + (l[0] - l[1]));
        }
    }
}
