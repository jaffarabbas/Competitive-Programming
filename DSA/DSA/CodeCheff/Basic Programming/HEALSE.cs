using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class HEALSE
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine(t > 8 ? "MORE" : t == 8 ? "PERFECT" : "LESS");
        }
    }
}
