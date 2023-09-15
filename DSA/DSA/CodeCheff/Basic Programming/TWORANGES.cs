using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class TWORANGES
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] st = Console.ReadLine().Split(" ");
                int a = Convert.ToInt32(st[0]);
                int b = Convert.ToInt32(st[1]);
                int c = Convert.ToInt32(st[2]);
                int d = Convert.ToInt32(st[3]);
                int count = 0, j;
                for (j = 1; j <= 10; j++)
                {
                    if ((a <= j && j <= b) || (c <= j && j <= d)) count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
