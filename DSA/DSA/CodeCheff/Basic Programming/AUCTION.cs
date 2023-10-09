using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class AUCTION
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int a = 0;
                int le = l[0];
                for (int i = 1; i <= le; i++)
                {
                    if (a < 0)
                    {
                        a = -1;
                        break;
                    }
                    a = l[0] - l[1];
                }
                Console.WriteLine(l[0] < l[1] ? 0 : a);
            }
        }
    }
}
