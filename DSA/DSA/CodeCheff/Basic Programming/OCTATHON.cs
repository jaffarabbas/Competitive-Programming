using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class OCTATHON
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            if(t < 3)
            {
                Console.WriteLine("GOLD");
            }else if(t >= 3 && t < 6)
            {
                Console.WriteLine("SILVER");
            }else
            {
                Console.WriteLine("BRONZE");
            }
        }
    }
}
