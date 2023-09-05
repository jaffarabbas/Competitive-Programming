using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class DRUNKALK
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int w = int.Parse(Console.ReadLine());
                int s = 0;
                for (int i = 1; i <= w; i++)
                {
                    if (i % 2 != 0)
                    {
                        s += 3;
                    }
                    else
                    {
                        s -= 1;
                    }
                }
                Console.WriteLine(s);
            }
        }
    }
}
