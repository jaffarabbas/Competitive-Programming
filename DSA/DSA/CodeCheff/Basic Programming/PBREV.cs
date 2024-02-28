using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class PBREV
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                int[] li = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int count = 0;
                for (int i = 0; i < l; i++)
                {
                    if (li[i] > 4)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count == l ? "YES" : "NO");
            }
        }
    }
}
