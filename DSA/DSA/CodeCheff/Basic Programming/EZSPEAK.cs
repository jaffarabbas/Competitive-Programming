﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class EZSPEAK
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int le = int.Parse(Console.ReadLine());
                string l = Console.ReadLine();
                char[] a = { 'a', 'e', 'i', 'o', 'u' };
                int count = 0;
                for (int i = 0; i < le; i++)
                {
                    char c = l[i];
                    if (count >= 4)
                        break;
                    if (!a.Contains(c))
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                }
                if (count >= 4)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
