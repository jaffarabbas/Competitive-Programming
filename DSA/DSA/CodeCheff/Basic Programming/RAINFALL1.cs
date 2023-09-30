using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    public class RAINFALL1
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                if(l < 3)
                {
                    Console.WriteLine("LIGHT");
                }else if(l >= 7)
                {
                    Console.WriteLine("HEAVY");
                }
                else if(l >= 3 && l < 7)
                {
                    Console.WriteLine("MODERATE");
                }
            }
        }
    }
}
