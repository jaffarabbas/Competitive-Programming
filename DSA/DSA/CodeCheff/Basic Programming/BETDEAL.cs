﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class BETDEAL
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string[] lines = Console.ReadLine().Split(' ');
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                int ap = (a / 100) * 100;
                int bp = (b / 100) * 200;
                int af = 100 - ap;
                int bf = 200 - bp;
                if (af == bf)
                {
                    Console.WriteLine("BOTH");
                }
                else if (af < bf)
                {
                    Console.WriteLine("FIRST");
                }else if(bf < af) {
                    Console.WriteLine("SECOND");

                } 
                t--;
            }
        }
    }
}
