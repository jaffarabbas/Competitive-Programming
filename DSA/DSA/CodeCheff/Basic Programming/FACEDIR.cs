using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FACEDIR
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int d = int.Parse(Console.ReadLine());
                int a = 0;
                for (int i = 1; i <= d; i++)
                {
                    a += 90;
                    if (a > 270)
                    {
                        a = 0;
                    }
                }
                if (a == 0)
                {
                    Console.WriteLine("North");
                }
                else if (a == 90)
                {
                    Console.WriteLine("East");
                }
                else if (a == 180)
                {
                    Console.WriteLine("South");
                }
                else if (a == 270)
                {
                    Console.WriteLine("West");
                }
            }
        }
    }
}
