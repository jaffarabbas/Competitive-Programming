using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CHEFTRANS
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                int c = int.Parse(lines[2]);

                if(a+b < c)
                {
                    Console.WriteLine("PLANEBUS");
                }else if(a+b > c)
                {
                    Console.WriteLine("TRAIN");
                }else if(a+b == c)
                {
                    Console.WriteLine("EQUAL");
                }
            }
        }
    }
}
