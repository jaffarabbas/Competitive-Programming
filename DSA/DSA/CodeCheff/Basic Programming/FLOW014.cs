using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FLOW014
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] l = Console.ReadLine().Split(' ');
                double a = double.Parse(l[0]);
                double b = double.Parse(l[1]);
                double c = double.Parse(l[2]);

                if (a > 50 && b < 0.7 && c > 5600)
                {
                    Console.WriteLine(10);
                }
                else if (a > 50 && b < 0.7)
                {
                    Console.WriteLine(9);
                }
                else if (b < 0.7 && c > 5600)
                {
                    Console.WriteLine(8);
                }
                else if (a > 50 && c > 5600)
                {
                    Console.WriteLine(7);
                }
                else if (a > 50 || b < 0.7 || c > 5600)
                {
                    Console.WriteLine(6);
                }
                else
                {
                    Console.WriteLine(5);
                }
            }
        }
    }
}
