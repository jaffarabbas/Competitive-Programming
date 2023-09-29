using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class STOCKMARKET
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());  
            while (t-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                Array.Sort(arr);
                int f = 0;
                for (int i = 1; i < l; i++)
                {
                    f += arr[i];
                }
                Console.WriteLine(f);
            }
        }
    }
}
