
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
                double a = int.Parse(Console.ReadLine());
                double h = 0, d = 0;
                if (a < 1500)
                {
                    Console.WriteLine(a + (0.1 * a) + (0.9 * a));
                }
                else
                {
                    Console.WriteLine(a + 500 + (0.98 * a));
                }
            }
        }   
    }
}