using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class PPSUM
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int a = 0;
                while (l[0] > 0)
                {
                    int s = 0;
                    for (int i = 1; i <= l[1]; i++)
                    {
                        s += i;
                    }
                    l[1] = s;
                    a = s;
                    l[0]--;
                }
                Console.WriteLine(a);
            }
        }
    }
}
