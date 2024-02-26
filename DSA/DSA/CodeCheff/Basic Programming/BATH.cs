using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class BATH
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                if ((l[1] * 2) <= l[0])
                {
                    Console.WriteLine(l[0] / (2 * l[1]));
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
