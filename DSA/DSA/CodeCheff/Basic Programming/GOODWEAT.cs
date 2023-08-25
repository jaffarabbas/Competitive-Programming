using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class GOODWEAT
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0) 
            {
                int count = 0, count2 = 0;
                string[] l = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(l, int.Parse);
                foreach (int i in a)
                {
                    if(i == 1)
                    {
                        count++;
                    }
                    else
                    {
                        count2++;
                    }
                }
                if(count > count2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
