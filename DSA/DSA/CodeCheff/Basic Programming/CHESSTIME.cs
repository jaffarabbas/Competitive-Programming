using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CHESSTIME
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                l *= 60;
                int r = l / 20;
                Console.WriteLine(r);
            }
        }
    }
}
