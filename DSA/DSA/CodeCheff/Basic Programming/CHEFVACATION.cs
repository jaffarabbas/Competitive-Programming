using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CHEFVACATION
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
                if ((x+y) <= z)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
