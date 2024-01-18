using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    public class PHONEYR
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            string a = "";
            int j = 0;
            for (int i = 1; i <= 2; i++)
            {
                j = t % 10;
                a += (j).ToString();
                t /= 10;
            }
            Console.WriteLine("K" + a[1] + a[0]);
        }
    }
}
