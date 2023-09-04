using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CARCHOICE
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                double x = double.Parse(lines[0]);
                double y = double.Parse(lines[1]);
                double a = double.Parse(lines[2]);
                double b = double.Parse(lines[3]);

                if ((a / x) < (b / y))
                {
                    Console.WriteLine(-1);
                }else if ((a / x) == (b / y))
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(1);
                }
            }
        }
    }
}
