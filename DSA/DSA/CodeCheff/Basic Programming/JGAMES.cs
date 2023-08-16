using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class JGAMES
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string[] lines = Console.ReadLine().Split(' ');
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                for (int i = 1; i <= b; i++)
                {
                    if (a > b)
                    {
                        //-
                        a -= 1;
                    }
                    else
                    {
                        //+
                        a += 1;
                    }
                }
                if(a%2 == 0)
                {
                    Console.WriteLine("Janmansh");
                }
                else
                {
                    Console.WriteLine("Jay");
                }
                t--;
            }
        }
    }
}
