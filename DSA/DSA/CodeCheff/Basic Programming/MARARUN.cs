using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class MARARUN
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] st = Console.ReadLine().Split(" ");
                int D = Convert.ToInt32(st[0]);
                int d = Convert.ToInt32(st[1]);
                int a = Convert.ToInt32(st[2]);
                int b = Convert.ToInt32(st[3]);
                int c = Convert.ToInt32(st[4]);
                int r = D * d;
                if(r >= 10 && r < 21)
                {
                    Console.WriteLine(a);
                }else if(r >= 21 && r < 42)
                {
                    Console.WriteLine(b);
                }else if(r >= 42)
                {
                    Console.WriteLine(c);
                }
                else if(r < 10)
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
