using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class OFFBY1
    {
        public static void func()
        {
            string[] lines = Console.ReadLine().Split(" ");
            int a  = int.Parse(lines[0]);
            int b = int.Parse(lines[1]);
            int r = a + b;
            r = int.Parse(r.ToString() + "1");
            Console.WriteLine(r);
        }
    }
}
