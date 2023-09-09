using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class UTKPLC
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] d = Console.ReadLine().Split(" ");
                string[] d2 = Console.ReadLine().Split(" ");
                char[] ca = Array.ConvertAll(d, Char.Parse);
                char[] cp = Array.ConvertAll(d2, Char.Parse);
                char cp1 = cp[0];
                char cp2 = cp[1];
                int cpa = 0, cpa2 = 0;
                for (int i = 0; i < ca.Length; i++)
                {
                    if (ca[i] == cp1)
                    {
                        cpa = i;
                    }else if (ca[i] == cp2)
                    {
                        cpa2 = i;
                    }
                }
                Console.WriteLine(cpa+" "+cpa2);
            }
        }
    }
}
