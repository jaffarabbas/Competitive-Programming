using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SEATNUMBER
    {
        public static void func()
        {
            int a = int.Parse(Console.ReadLine());
            while (a > 0)
            {

                int x = int.Parse(Console.ReadLine());
                string v = "";
                if (x <= 15)
                {
                    v = "Lower";
                    if(x <= 10)
                    {
                        v = v + " Double";
                    }
                    else
                    {
                        v = v + " Single";
                    }
                }
                else
                {
                    v = "Upper";
                    if (x <= 25)
                    {
                        v = v + " Double";
                    }
                    else
                    {
                        v = v + " Single";
                    }
                }
                Console.WriteLine(v);
                a--;
            }
        }
    }
}
