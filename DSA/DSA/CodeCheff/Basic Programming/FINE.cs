using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FINE
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                if (l > 100)
                {
                    Console.WriteLine(2000);
                }
                else if (l <= 70)
                {
                    Console.WriteLine(0);
                }
                else if (l > 70 && l <= 100)
                {
                    Console.WriteLine(500);
                }
            }
        }
    }
}
