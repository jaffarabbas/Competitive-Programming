using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class IED
    {
        public static void func()
        {
            int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int a = l[0] * l[2];
            int b = l[1] * l[2];
            Console.WriteLine(a > b ? a : b);
        }
    }
}
