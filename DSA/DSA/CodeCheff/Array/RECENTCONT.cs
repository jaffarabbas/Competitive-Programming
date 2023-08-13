using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Array
{
    internal class RECENTCONT
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int count1= 0 ,count2= 0 ;
                int l = int.Parse(Console.ReadLine());
                string[] lines = Console.ReadLine().Split(' ');
                for (int i = 0; i < l; i++)
                {
                    if (lines[i] == "START38")
                    {
                        count1++;
                    }
                    else if (lines[i] == "LTIME108")
                    {
                        count2++;
                    }
                }
                Console.WriteLine(count1+" "+count2);
                t--;
            }
        }
    }
}
