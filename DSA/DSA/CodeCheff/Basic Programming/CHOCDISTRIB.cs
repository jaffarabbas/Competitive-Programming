using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CHOCDISTRIB
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine(l%2 == 0 ? (l / 2) + "" + l : (l / 2) + 1 + "" + l);
            }
        }
    }
}
