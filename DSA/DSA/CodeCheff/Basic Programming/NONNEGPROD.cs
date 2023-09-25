using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class NONNEGPROD
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int l = int.Parse(Console.ReadLine());
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int r = 1;
                for (int i = 0; i < l; i++)
                {
                    if (arr[i] < 0)
                    {
                        r *= -1;
                    }else if (arr[i] == 0)
                    {
                        r = 0;
                        break;
                    }
                }
                if (r < 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
