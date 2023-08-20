using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class LAZYCHF
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(' ');
                int x = int.Parse(lines[0]);
                int m = int.Parse(lines[1]);
                int d = int.Parse(lines[2]);
                int f = m * x;
                int f2 = x + d;
                int result = Math.Min(f, f2);
                Console.WriteLine(result);
            }
        }
    }
}
