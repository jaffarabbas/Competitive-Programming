using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Strings
{
    internal class BROKENSTRING
    {
        public static void func()
        
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int l = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                int b = l / 2;
                string n1 = s.Substring(0,b);
                string n2 = s.Substring(b,b);
                if(n1 == n2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                t--;
            }
        }
    }
}
