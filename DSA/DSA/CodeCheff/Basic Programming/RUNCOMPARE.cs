using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class RUNCOMPARE
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int c = int.Parse(Console.ReadLine());
                string[] lines = Console.ReadLine().Split(" ");
                string[] lines2 = Console.ReadLine().Split(" ");
                int[] a1 = Array.ConvertAll(lines, int.Parse);
                int[] a2 = Array.ConvertAll(lines2, int.Parse);
                int count = 0;
                for (int i = 0; i < c; i++)
                {
                    if (a1[i] * 2 >= a2[i] && a2[i] * 2 >= a1[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
