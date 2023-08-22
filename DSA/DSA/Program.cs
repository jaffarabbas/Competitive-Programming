
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
                if ((a*b) % c == 0)
                {
                    Console.WriteLine((a*b)+" "+c);
                }else if ((a*c) % b == 0)
                {
                    Console.WriteLine((a*c)+" "+b);
                }else if((b * c) % a == 0)
                {
                    Console.WriteLine((b*c)+" "+a);
                }
                else
                {
                    Console.WriteLine(-1);
                }
                
            }
        }   
    }
}