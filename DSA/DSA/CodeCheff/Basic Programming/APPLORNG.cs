using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class APPLORNG
    {
        public static void func()
        {
            int a = int.Parse(Console.ReadLine());
            int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Console.WriteLine(a >= l[0] + l[1] ? "YES" : "NO");
        }
    }
}
