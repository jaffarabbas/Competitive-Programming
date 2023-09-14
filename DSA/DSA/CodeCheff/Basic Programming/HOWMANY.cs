using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class HOWMANY
    {
        public static void func()
        {
            long t = long.Parse(Console.ReadLine());
            long len = 0;
            while (t > 0)
            {
                t /= 10;
                len++;
            }
            if (len > 3)
            {
                Console.WriteLine("More than 3 digits");
            }
            else
            {
                Console.WriteLine(len);
            }
        }
    }
}
