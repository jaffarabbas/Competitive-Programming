using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class LARGESECOND
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int l = int.Parse(Console.ReadLine());
                string[] lines = Console.ReadLine().Trim().Split(" ");
                int[] arr = Array.ConvertAll(lines, int.Parse);
                int max1 = int.MinValue, max2 = int.MinValue;
                foreach (int i in arr)
                {
                    if (i > max1)
                    {
                        max2 = max1;
                        max1 = i;
                    }
                    if (i > max2 && i != max1)
                    {
                        max2 = i;
                    }
                }

                Console.WriteLine(max1 + max2);
            }
        }
    }
}
