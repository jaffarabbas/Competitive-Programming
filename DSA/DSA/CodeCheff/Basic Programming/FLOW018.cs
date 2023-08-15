using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FLOW018
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while((t--) > 0)
            {
                int a = int.Parse(Console.ReadLine());
                int v = 1;
                for (int i = 1; i <= a; i++)
                {
                    v *= i;
                }
                Console.WriteLine(v);
            }
        }
    }
}
