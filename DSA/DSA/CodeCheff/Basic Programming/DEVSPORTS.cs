using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class DEVSPORTS
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                int x = int.Parse(lines[0]);
                int y = int.Parse(lines[1]);
                int a = int.Parse(lines[2]);
                int b = int.Parse(lines[3]);
                int c = int.Parse(lines[4]);
                
                if ((x - y) >= (a+b+c))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
