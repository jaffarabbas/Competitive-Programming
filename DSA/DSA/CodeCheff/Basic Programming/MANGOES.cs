using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class MANGOES
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
                int temp = 0;
                for (int i = 1; i <= l[2]; i++)
                {
                    int a = ((i * l[0]) + l[1]);
                    if(a <= l[2])
                    {
                        temp = i;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(temp);
            }
        }
    }
}
