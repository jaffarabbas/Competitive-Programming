using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class PENALTY
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                int[] arr = Array.ConvertAll(lines, int.Parse);
                int count = 0 , count2 = 0;
                foreach (var item in arr)
                {
                    if(item %2 == 0 && item == 1)
                    {
                        count++;
                    }else if(item % 2 != 0 && item == 1)
                    {
                        count2++;
                    }
                }
                if(count > count2)
                {
                    Console.WriteLine(1);
                }else if(count < count2)
                {
                    Console.WriteLine(2);
                }else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
