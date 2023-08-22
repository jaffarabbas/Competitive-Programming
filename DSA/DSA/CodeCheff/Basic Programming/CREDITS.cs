using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CREDITS
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int a = int.Parse(Console.ReadLine());
                if (a > 65)
                {
                    Console.WriteLine("Overload");
                }
                else if (a < 35)
                {
                    Console.WriteLine("Underload");
                }
                else
                {
                    Console.WriteLine("Normal");
                }
            }
        }
    }
}
