using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FINDK3
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(' ');
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                int c = int.Parse(lines[1]);
                int f = 0,w = 0;
                if(a%b == 0)
                {
                    f = a * b;
                    w = c;
                }else if(a % c == 0)
                {
                    f = a * c;
                    w = b;
                }else if(b%c == 0)
                {
                    f = b * c;
                    w = a;
                }
                Console.WriteLine(f+" "+w);
            }
        }
    }
}
