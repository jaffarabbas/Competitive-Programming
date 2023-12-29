using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CHEAPFOOD
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a > 1000 ? a * 0.10 : 100);
            }
        }
    }
}
