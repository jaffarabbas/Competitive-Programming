using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class AVGPROBLEM
    {
        public static void func()
        {   
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                double a = (int)(l[0] + l[1]) / 2.0;
                Console.WriteLine(a > l[2] ? "YES" : "NO");
            }
        }
    }
}
