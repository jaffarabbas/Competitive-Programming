using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class BROKENPHONE
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                if (l[0] < l[1])
                {
                    Console.WriteLine("REPAIR");
                }else if (l[0] > l[1])
                {
                    Console.WriteLine("NEW PHONE");
                }
                else
                {
                    Console.WriteLine("ANY");
                }
            }
        }
    }
}
