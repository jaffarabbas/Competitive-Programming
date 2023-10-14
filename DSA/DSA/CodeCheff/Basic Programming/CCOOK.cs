using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class CCOOK
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                int a = 0;
                foreach (int i in l)
                {
                    if(i == 1)
                        a++;
                }
                if(a == 0)
                {
                    Console.WriteLine("Beginner");
                }else if(a == 1)
                {
                    Console.WriteLine("Junior Developer");
                }
                if (a == 2)
                {
                    Console.WriteLine("Middle Developer");
                }
                if (a == 3)
                {
                    Console.WriteLine("Senior Developer");
                }
                if (a == 4)
                {
                    Console.WriteLine("Hacker");
                }
                if (a == 5)
                {
                    Console.WriteLine("Jeff Dean");
                }
            }
        }
    }
}
