using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SST
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                if ((l[0] * 100) == (l[1] * 50))
                {
                    Console.WriteLine("ANY");
                }
                else if ((l[0] * 100) > (l[1] * 50))
                {
                    Console.WriteLine("FIRST");
                }
                else
                {
                    Console.WriteLine("SECOND");
                }
            }
        }
    }
}
