using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CRICRANK
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int[] l2 = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int count = 0, count2 = 0;
                for (int i = 0; i < l.Length; i++)
                {
                    if (l[i] > l2[i])
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
                    Console.WriteLine("A");
                }
                else
                {
                    Console.WriteLine("B");
                }
            }
        }
    }
}
