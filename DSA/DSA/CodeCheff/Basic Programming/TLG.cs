using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class TLG
    {
        public static void func()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int y = 0;
            int maxDiff = 0;
            int result = 0;
            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(s[0]);
                int b = Convert.ToInt32(s[1]);

                x += a;
                y += b;

                int diff = Math.Abs(x - y);

                if (diff > maxDiff)
                {
                    maxDiff = diff;
                    int result1 = (x > y) ? 1 : 2;
                    result = result1;
                }

            }

            Console.WriteLine(result + " " + maxDiff);
        }
    }
}
