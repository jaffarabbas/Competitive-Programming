using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CHSFORMT
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                if (a + b < 3)
                {
                    Console.WriteLine(1);
                }
                else if ((a + b) >= 3 && (a + b) <= 10)
                {
                    Console.WriteLine(2);
                }
                else if((a + b) >= 11 && (a + b) <= 60)
                {
                    Console.WriteLine(3);
                }
                else if((a + b) > 60)
                {
                    Console.WriteLine(4);
                }
            }
        }
    }
}
