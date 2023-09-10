using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SNCKYEAR
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int x = int.Parse(Console.ReadLine());
                int[] y = { 2010, 2015, 2016, 2017, 2019 };
                if (y.Contains(x))
                {
                    Console.WriteLine("HOSTED");
                }
                else
                {
                    Console.WriteLine("NOT HOSTED");
                }
            }
        }
    }
}
