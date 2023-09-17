using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SAVWATER
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] st = Console.ReadLine().Split(" ");
                int h = Convert.ToInt32(st[0]);
                int x = Convert.ToInt32(st[1]);
                int y = Convert.ToInt32(st[2]);
                int c = Convert.ToInt32(st[3]);
                int r = (x + (y / 2)) * h;
                if(r <= c)
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
