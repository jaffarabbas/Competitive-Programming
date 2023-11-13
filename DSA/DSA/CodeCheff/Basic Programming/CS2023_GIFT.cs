using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CS2023_GIFT
    {
        public static void func()
        {
            int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int a = l[1] - l[0];
            Console.WriteLine(a <= l[2] ? "YES" : "NO");
        }
    }
}
