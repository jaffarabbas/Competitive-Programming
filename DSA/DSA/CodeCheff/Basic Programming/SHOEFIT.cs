using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SHOEFIT
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] st = Console.ReadLine().Split(" ");
                int a = Convert.ToInt32(st[0]);
                int b = Convert.ToInt32(st[1]);
                int c = Convert.ToInt32(st[2]);
                if(a == 0 && b == 1 || b == 1 && a == 0 || a == 0 && c == 1 || a == 1 && c == 0 || b == 0 && c == 1 || b == 1 && c == 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
