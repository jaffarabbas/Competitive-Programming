using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class GENE01
    {
        public static void func()
        {
            string[] lines = Console.ReadLine().Split(" ");
            char a = char.Parse(lines[0]);
            char b = char.Parse(lines[1]);
            char[] l = { 'R', 'B', 'G' };
            int v1 = Array.FindIndex(l, value => value.Equals(a));
            int v2 = Array.FindIndex(l, value => value.Equals(b));
            if(v1 <= v2)
            {
                Console.WriteLine(l[v1]);
            }
            else
            {
                Console.WriteLine(l[v2]);
            }
        }
    }
}
