using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class MINPIZZA
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int n = l[0] * l[1];
                int d = n / 4;
                if (n % 4 != 0)
                {
                    Console.WriteLine(d+1);
                }
                else
                {
                Console.WriteLine(d);
                }
            }
        }
    }
}
