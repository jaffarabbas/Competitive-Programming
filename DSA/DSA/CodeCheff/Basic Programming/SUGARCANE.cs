using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SUGARCANE
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                int a = l * 50;
                int a2 = (a * 20) / 100;
                int a3 = (a * 20) / 100;
                int a4 = (a * 30) / 100;
                Console.WriteLine(a - ((a2 + a3) +a4));
            }
        }
    }
}
