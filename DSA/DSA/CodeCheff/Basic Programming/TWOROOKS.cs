using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class TWOROOKS
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                Console.WriteLine(l[0] == l[2] || l[1] == l[3] ? "YES" : "NO");
            }
        }
    }
}
