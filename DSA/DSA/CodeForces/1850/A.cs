using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeForces._1850
{
    internal class A
    {
        public static void func()
        {
            int a = int.Parse(Console.ReadLine());
            while (a > 0)
            {
                string[] lines = Console.ReadLine().Split(' ');
                int x = int.Parse(lines[0]);
                int y = int.Parse(lines[1]);
                int z = int.Parse(lines[2]);
                if((x+y) > z || (x+z) > y)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                a--;
            }
        }
    }
}
