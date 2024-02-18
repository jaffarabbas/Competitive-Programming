using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class WINNERR
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int a = l[0] > l[1] ? l[0] : l[1];
                int b = l[2] > l[3] ? l[2] : l[3];
                if (a < b)
                {
                    Console.WriteLine("P");
                }else if(b < a)
                {
                    Console.WriteLine("Q");
                }
                else
                {
                    Console.WriteLine("TIE");
                }
            }
        }
    }
}
