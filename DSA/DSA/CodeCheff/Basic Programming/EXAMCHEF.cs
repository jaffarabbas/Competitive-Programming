using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class EXAMCHEF
    {
        public void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int a = l[0] * l[1];
                float p = a * 0.5f;
                Console.WriteLine(l[2] > p ? "YES" : "NO");
            }
        }
    }
}
