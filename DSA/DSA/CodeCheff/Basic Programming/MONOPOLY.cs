using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class MONOPOLY
    {
        public void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                Array.Sort(l);
                Console.WriteLine(l[0] + l[1] < l[2] ? "YES" : "NO");
            }
        }
    }
}
