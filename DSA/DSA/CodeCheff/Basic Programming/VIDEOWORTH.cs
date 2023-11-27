using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class VIDEOWORTH
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int t2 = int.Parse(Console.ReadLine());
                Console.WriteLine((t2 * 24) * 1000);
            }
        }
    }
}
