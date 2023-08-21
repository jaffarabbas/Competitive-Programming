
using System;

namespace DSA 
{
    internal class Program
    {
        public static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(' ');
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                int c = int.Parse(lines[2]);
                int f = 0, w = 0;
                bool flag = false;
                if (a % b == 0)
                {
                    f = a * c;
                    w = b;
                }
                else if (a % c == 0)
                {
                    f = a * b;
                    w = c;
                }
                else if (b % c == 0)
                {
                    f = b * a;
                    w = c;
                }
                else
                {
                    flag = true;
                }
                if (!flag)
                {
                    Console.WriteLine(f + " " + w);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
        }   
    }
}