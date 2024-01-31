using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class BIRDFARM
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(""), int.Parse);
                if (l[2] % l[0] == 0 && l[2] % l[1] == 0)
                {
                    Console.WriteLine("ANY");
                }
                else if (l[2] % l[0] == 0 && l[2] % l[1] != 0)
                {
                    Console.WriteLine("CHICKEN");
                }
                else if (l[2] % l[0] != 0 && l[2] % l[1] == 0)
                {
                    Console.WriteLine("DUCK");
                }
                else
                {
                    Console.WriteLine("NONE");
                }
            }
        }
    }
}
