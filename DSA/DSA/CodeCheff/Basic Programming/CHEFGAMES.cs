using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CHEFGAMES
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int count = 0;
                foreach (var item in l)
                {
                    if(item == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count == 4 ? "IN" : "OUT");
            }
        }
    }
}
