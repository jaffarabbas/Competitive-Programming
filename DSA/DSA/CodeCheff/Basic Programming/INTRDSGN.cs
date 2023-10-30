using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class INTRDSGN
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int a = l[0] + l[1];
                int a1 = l[2] + l[3];
                Console.WriteLine(a < a1 ? a : a1);
            }
        }
    }
}
