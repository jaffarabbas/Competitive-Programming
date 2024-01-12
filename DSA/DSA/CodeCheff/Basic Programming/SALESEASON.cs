using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SALESEASON
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                if(l <= 100)
                {
                    Console.WriteLine(l);
                }else if (l > 100 && l <= 1000)
                {
                    Console.WriteLine(l - 25);
                }else if (l > 1000 && l <= 5000)
                {
                    Console.WriteLine(l - 100);
                }
                else if(l > 5000)
                {
                    Console.WriteLine(l - 500);
                }
            }
        }
    }
}
