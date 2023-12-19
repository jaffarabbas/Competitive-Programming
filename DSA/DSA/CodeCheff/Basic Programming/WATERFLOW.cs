using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class WATERFLOW
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                int n = l[0] + (l[2] * l[3]);
                if (n < l[1])
                {
                    Console.WriteLine("Unfilled");
                }
                else if(n > l[1])
                {
                    Console.WriteLine("overFlow");
                }
                else if(n == l[1])
                {
                    Console.WriteLine("filled");
                }
            }
        }
    }
}
