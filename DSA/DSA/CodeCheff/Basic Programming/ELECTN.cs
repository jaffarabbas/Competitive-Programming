using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class ELECTN
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string[] lines = Console.ReadLine().Split(' ');
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                int count = 0;
                string[] p = Console.ReadLine().Split(' ');
                int[] arr = new int[a];
                for (int i = 0; i < p.Length; i++)
                {
                    arr[i] = int.Parse(p[i]);
                }
                foreach (int i in arr)
                {
                    if(i >= b)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                t--;
            }
        }
    }
}
