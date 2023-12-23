using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SONGS
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                if (l[0] > l[1])
                {
                    Console.WriteLine(l[0] / (l[1] * 3));
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
