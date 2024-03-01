using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class BRUNCH
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] li = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int a = li[0] / li[1];
                Console.WriteLine(a > 20 ? 20 : a);
            }
        }
    }
}
