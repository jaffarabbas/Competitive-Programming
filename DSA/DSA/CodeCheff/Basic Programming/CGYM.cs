using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CGYM
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                int d = l[2] - l[0];
                int d2 = d - l[1];
                Console.WriteLine(d2 >= 0 ? 2 : d >= 0 ? 1 : 0 );
            }
        }
    }
}
