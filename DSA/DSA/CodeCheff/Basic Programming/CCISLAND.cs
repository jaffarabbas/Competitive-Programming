using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CCISLAND
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                int x = int.Parse(lines[0]);
                int y = int.Parse(lines[1]);
                int x1 = int.Parse(lines[2]);
                int y1 = int.Parse(lines[3]);
                int d = int.Parse(lines[4]);
                double r1 = x / x1; double r2 = y / y1;
                double min = r1 > r2 ? r2: r1;
                if(min < d)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
