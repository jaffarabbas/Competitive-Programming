using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class XJUMP
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string[] lines = Console.ReadLine().Split(' ');
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                int es = a / b;
                int er = a % b;
                if(er == 0)
                {
                    Console.WriteLine(es);
                }
                else
                {
                    int f = es + er;
                    Console.WriteLine(f);
                }
                t--;
            }
        }
    }
}
