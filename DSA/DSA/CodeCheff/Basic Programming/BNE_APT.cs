using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class BNE_APT
    {
        public static void func()
        {
            int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            int[] l2 = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Console.WriteLine(l[0] * l2[0] + l[1] * l2[1]);
        }
    }
}
