using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class MIXTURE
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                if(a > 0 && b > 0)
                {
                    Console.WriteLine("Solution");
                }else if(a == 0)
                {
                    Console.WriteLine("Liquid");
                }
                else
                {
                    Console.WriteLine("Solid");
                }
            }
        }
    }
}
