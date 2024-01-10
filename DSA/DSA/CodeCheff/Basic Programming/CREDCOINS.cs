using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CREDCOINS
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int a = l[0] * l[1];
                if (a >= 100)
                {
                    int n = a / 100;
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
