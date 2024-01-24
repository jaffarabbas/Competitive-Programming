using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CHEFCAND
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                if (l[0] >= l[1])
                {
                    if ((l[0] - l[1]) % 4 == 0)
                    {
                        Console.WriteLine((l[0] - l[1]) / 4);
                    }
                    else
                    {
                        Console.WriteLine((l[0] - l[1]) / 4 + 1);
                    }
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
