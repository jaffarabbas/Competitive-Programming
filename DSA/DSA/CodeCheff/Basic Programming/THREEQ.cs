using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class THREEQ
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while((t--) > 0)
            {
                int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int count = 0,count2 = 0;
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] == 1)
                    {
                        count++;
                    }
                    if (arr2[i] == 1)
                    {
                        count2++;
                    }
                }
                if(count > count)
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
