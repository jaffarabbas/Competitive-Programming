using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class VISA
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                int x1 = int.Parse(lines[0]);
                int x2 = int.Parse(lines[1]);
                int y1 = int.Parse(lines[2]);
                int y2 = int.Parse(lines[3]);               
                int z1 = int.Parse(lines[4]);
                int z2 = int.Parse(lines[5]);

                if(x2 >= x1 && y2 >= y1 && z2 <= z1)
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
