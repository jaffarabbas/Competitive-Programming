using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FLOW008
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while((t--) > 0)
            {
                int a = int.Parse(Console.ReadLine());
                if(a < 10 || a < 0)
                {
                    Console.WriteLine("Thanks for helping Chef!");
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
