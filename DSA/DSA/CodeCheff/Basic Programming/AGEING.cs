using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class AGEING
    {
        public static void func()
        {
            int a = int.Parse(Console.ReadLine());
            while (a > 0)
            {
                int x = int.Parse(Console.ReadLine());
                int f = x - 10;
                Console.WriteLine(f);
                a--;
            }
        }
    }
}
