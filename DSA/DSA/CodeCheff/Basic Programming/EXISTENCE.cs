using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class EXISTENCE
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                long a = long.Parse(lines[0]);
                long b = long.Parse(lines[1]);
                if(a*a*a*a+4*b*b == 4*a*a*b)
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
