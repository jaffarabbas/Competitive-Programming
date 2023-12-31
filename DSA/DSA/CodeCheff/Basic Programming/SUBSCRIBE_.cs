using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SUBSCRIBE_
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                int count = 0;
                int c = l[0] / 6;
                if (l[0] % 6 != 0)
                {
                    count++;
                }
                int res = c + count;
                Console.WriteLine(res * l[1]);
            }
        }
    }
}
