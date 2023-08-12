using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeForces._1850
{
    internal class B
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int max = 0;
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    string[] lines = Console.ReadLine().Split(' ');
                    int a = int.Parse(lines[0]);
                    int b = int.Parse(lines[1]);
                    if (a <= 10)
                    {
                        if (max < b)
                        {
                            max = b;
                            count = i + 1;
                        }
                    }
                }
                Console.WriteLine(count);
                t--;
            }
        }
    }
}
