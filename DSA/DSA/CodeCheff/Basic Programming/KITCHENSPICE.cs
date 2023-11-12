using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class KITCHENSPICE
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                 int l = int.Parse(Console.ReadLine());
                 if( l < 4)
                {
                    Console.WriteLine("MILD");
                }else if (l >= 4 && l < 7)
                {
                    Console.WriteLine("MEDIUM");
                }
                else
                {
                    Console.WriteLine("HOT");
                }
            }
        }
    }
}
