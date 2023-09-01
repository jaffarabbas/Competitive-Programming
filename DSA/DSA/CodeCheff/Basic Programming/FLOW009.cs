using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FLOW009
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                int x = int.Parse(lines[0]);
                int y = int.Parse(lines[1]);
                double f = x * y;
                if(x > 1000)
                {
                    double d = (f / 100) * 10;
                    double result = f - d;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(f);
                }
            }
        }
    }
}
