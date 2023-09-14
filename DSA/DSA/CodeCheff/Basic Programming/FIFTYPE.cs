using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FIFTYPE
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int x = int.Parse(Console.ReadLine());
                int c = 0;
                if (x != 50)
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        if (x > 50)
                        {
                            x -= 3;
                            c++;
                        }
                        if (x < 50)
                        {
                            x += 2;
                            c++;
                        }
                        if (x == 50)
                        {
                            break;
                        }
                    }
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
