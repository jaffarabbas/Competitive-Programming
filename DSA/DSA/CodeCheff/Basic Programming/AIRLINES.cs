using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class AIRLINES
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int m = l[0] * 10;
                Console.WriteLine(m > l[1] ? l[1] * l[2] : m * l[2]);
            }
        }
    }
}
