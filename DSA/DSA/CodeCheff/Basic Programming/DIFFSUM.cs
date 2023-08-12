using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class DIFFSUM
    {
        public static void func()
        {
            string[] lines = Console.ReadLine().Split(' ');
            int a = int.Parse(lines[0]);
            int b = int.Parse(lines[1]);
            if(a > b)
            {
                int f = a - b;
                Console.WriteLine(f);
            }
            else
            {
                int f = a + b;
                Console.WriteLine(f);
            }
        }
    }
}
