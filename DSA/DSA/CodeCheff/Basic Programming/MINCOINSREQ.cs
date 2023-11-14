using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class MINCOINSREQ
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                int a = l % 10;
                Console.WriteLine(a);
            }
        }
    }
}
