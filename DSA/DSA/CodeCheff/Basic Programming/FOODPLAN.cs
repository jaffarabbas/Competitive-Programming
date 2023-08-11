using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FOODPLAN
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string[] lines = Console.ReadLine().Split(' ');
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                double temp = (double)a;
                double f = a * 0.10;
                temp = temp - f;
                if (temp == b)
                {
                    Console.WriteLine("EITHER");
                }
                else if (temp < b)
                {
                    Console.WriteLine("ONLINE");
                }
                else
                {
                    Console.WriteLine("DINING");
                }
                t--;
            }
        }
    }
}
