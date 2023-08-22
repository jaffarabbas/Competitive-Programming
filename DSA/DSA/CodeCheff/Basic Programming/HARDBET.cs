using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class HARDBET
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                int c = int.Parse(lines[2]);
                if (a < b && a < c)
                {
                    Console.WriteLine("Draw");
                }
                else if (b < a && b < c)
                {
                    Console.WriteLine("Bob");
                }
                else if (c < a && c < b)
                {
                    Console.WriteLine("Alice");
                }
            }   
        }
    }
}
