using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    public class CPRIVAL
    {
        public static void func()
        {
            int[] l = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            int[] l2 = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            Console.WriteLine(l[0] + l2[0] > l[1] + l2[1] ? "Dominater" : "Everule");
        }
    }
}
