using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class Class1
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int d = l[0] - l[1];
                if (d > l[1])
                {
                    Console.WriteLine(l[1]);
                }
                else
                {
                    Console.WriteLine(d);
                }
            }
        }
    }
}
