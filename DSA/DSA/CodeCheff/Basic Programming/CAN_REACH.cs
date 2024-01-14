using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    public class CAN_REACH
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int[] a = { 0, 0 };
                bool f = true,an = false;
                if (l[2] < 0)
                {
                    if(l[0] < 0 || l[1] < 0)
                    {

                    }
                }
                for (int i = 0; i < 1000; i++)
                {
                    if (f)
                    {
                        a[0] += l[2];
                    }
                    else
                    {
                        a[1] += l[2];
                    }
                    if (a[0] == l[0] && a[1] == l[1])
                    {
                        an = true;
                        break;
                    }
                    else
                    {
                        if (a[0] > l[0] && a[1] > l[1])
                        {
                            an = false;
                            break;
                        }
                    }
                    f = false;
                }
                if (an)
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
