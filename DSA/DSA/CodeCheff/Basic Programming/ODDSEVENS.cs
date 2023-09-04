using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class ODDSEVENS
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                double x = double.Parse(lines[0]);
                double y = double.Parse(lines[1]);
                if((x + y) %2 == 0)
                {
                    Console.WriteLine("Bob");
                }
                else
                {
                    Console.WriteLine("Alice");
                }
            }
        }
    }
}
