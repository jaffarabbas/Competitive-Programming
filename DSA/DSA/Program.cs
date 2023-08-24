
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
                float a = int.Parse(Console.ReadLine());
                float h = 0, d = 0;
                if (a < 1500)
                {
                    h = (a / 100) * 10;
                    d = (a / 100) * 90;
                }
                else
                {
                    h = 500;
                    d = (a / 100) * 98;
                }
                float f = a + h + d;
                Console.WriteLine(f);
            }
        }   
    }
}