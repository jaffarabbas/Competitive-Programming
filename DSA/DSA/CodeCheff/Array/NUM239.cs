using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Array
{
    internal class NUM239
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int count1 = 0;
                string[] lines = Console.ReadLine().Split(' ');
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                for (int i = a;i<=b;i++)
                {
                    if(i > 10)
                    {
                        int temp = i % 10;
                        if(temp == 2 || temp == 3 || temp == 9)
                        {
                            count1++;
                        }
                    }
                    if(i == 2 || i == 3 || i == 9)
                    {
                        count1++;
                    }
                }
                Console.WriteLine(count1);
                t--;
            }
        }
    }
}
