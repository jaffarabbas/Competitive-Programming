using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FAVOURITENUM
    {
        public static void func()
        {
            int a = int.Parse(Console.ReadLine());
            while (a > 0)
            {

                int x = int.Parse(Console.ReadLine());

                if (x % 7 == 0 && x % 2 == 0 )
                {
                    Console.WriteLine("Alice");
                }else if(x % 9 == 0 && x % 2 != 0)
                {
                    Console.WriteLine("Bob");
                }
                else
                {
                    Console.WriteLine("Charlie");
                }
                a--;
            }
        }
    }
}
