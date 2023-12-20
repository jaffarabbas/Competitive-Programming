using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SPCP1
    {
        public static void func()
        {
            int[] l = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            Console.WriteLine(l[0] >= 60 && l[1] <= 130 ? "YES" : "NO");
        }
    }
}
