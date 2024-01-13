using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class BLOBBYVOLLEY
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int l = int.Parse(Console.ReadLine());
                char[] list = Console.ReadLine().ToArray();
                int a = 0, b = 0;
                bool s = true;
                for (int i = 0; i < l; i++)
                {
                    if (list[i] == 'A')
                    {
                        if (s)
                        {
                            a++;
                        }
                        s = true;
                    }
                    else
                    {
                        if (!s)
                        {
                            b++;
                        }
                        s = false;
                    }
                }
                Console.WriteLine(a + " " + b);
            }
        }
    }
}
