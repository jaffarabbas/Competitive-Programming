using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CHEFBOTTLE
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int a = 0;
                int count = 0;
                for (int i = 1; i <= l[0]; i++) {
                    a = l[1] * i;
                    if (a > l[2])
                        break;
                    count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
