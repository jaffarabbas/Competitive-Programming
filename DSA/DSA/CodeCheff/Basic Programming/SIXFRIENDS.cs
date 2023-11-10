using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SIXFRIENDS
    {
        public static void func()
        {
            int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int a = l[0] * 3;
            int b = l[1] * 2;
            Console.WriteLine(a < b ? a : b);
        }
    }
}
