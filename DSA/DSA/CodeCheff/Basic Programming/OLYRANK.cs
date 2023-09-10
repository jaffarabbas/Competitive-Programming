using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class OLYRANK
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                int x = int.Parse(lines[0]);
                int y = int.Parse(lines[1]);
                int z = int.Parse(lines[2]);
                int x2 = int.Parse(lines[3]);
                int y2 = int.Parse(lines[4]);
                int z2 = int.Parse(lines[5]);

                if ((x+y+z) > (x2+y2+z2))
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(2);
                }
            }
        }
    }
}
