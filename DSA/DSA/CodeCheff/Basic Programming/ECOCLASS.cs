using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class ECOCLASS
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while((t--) > 0)
            {
                int l = int.Parse(Console.ReadLine());
                string[] arr1 = Console.ReadLine().Split(' ');
                string[] arr2 = Console.ReadLine().Split(' ');

                int[] ar1 = Array.ConvertAll(arr1, int.Parse);
                int[] ar2 = Array.ConvertAll(arr2, int.Parse);
                int count = 0;
                for (int i = 0; i < l; i++) 
                {
                    if (ar1[i] == ar2[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
