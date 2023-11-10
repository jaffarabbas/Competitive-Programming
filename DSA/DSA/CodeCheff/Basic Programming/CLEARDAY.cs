using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CLEARDAY
    {
        public static void func()
        {
            int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            Console.WriteLine(7 - l[0] - l[1]);
        }
    }
}
