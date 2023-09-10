using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CHEFCONTEST
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
                int w = int.Parse(lines[3]);
                int r1 = x + (z * 10);
                int r2 = y + (w * 10);
                if(r1 < r2)
                {
                    Console.WriteLine("Chef");
                }else if(r1 == r2)
                {
                    Console.WriteLine("Draw");
                }
                else
                {
                    Console.WriteLine("Chefina");
                }
            }
        }
    }
}
