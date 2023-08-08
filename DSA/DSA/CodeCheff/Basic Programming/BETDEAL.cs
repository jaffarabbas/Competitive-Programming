using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class BETDEAL
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string[] lines = Console.ReadLine().Split(' ');
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                int ap = (a / 100) * 100;
                int bp = (b / 100) * 200;
                if (ap == bp)
                {
                    Console.WriteLine("BOTH");
                }
                else if (ap < bp)
                {
                    Console.WriteLine("FIRST");
                }else if(bp < ap) {
                    Console.WriteLine("SECOND");

                } 
                t--;
            }
        }
    }
}
