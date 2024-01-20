using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class NOTEBOOK
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine((l * 1000)/100) ;
            }
        }
    }
}
