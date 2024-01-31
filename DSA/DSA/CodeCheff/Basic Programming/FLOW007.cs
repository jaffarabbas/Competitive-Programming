using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FLOW007
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(""), int.Parse);   
                for (int i = l.Length - 1;i>=0; i--)    
                {
                    if (l[i] == 0)
                    {
                        continue;
                    }
                    Console.Write(l[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
