using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FLOW011
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while((t--) > 0)
            {
                int a = int.Parse(Console.ReadLine());
                float h = 0,d = 0;
                if(a < 1500)
                {
                    h = (a / 10) * 100;
                    d = (a / 90) * 100;
                }
                else
                {
                    h = 500;
                    d = (a / 98) * 100;
                }
                float f = a + h + d;
                Console.WriteLine(f);
            }
        }
    }
}
