
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
                string[] d = Console.ReadLine().Split(" ");
                string[] d2 = Console.ReadLine().Split(" ");
                char[] ca = Array.ConvertAll(d, Char.Parse);
                char[] cp = Array.ConvertAll(d2, Char.Parse);
                char cp1 = cp[0];
                char cp2 = cp[1];
                int cpa = 0, cpa2 = 0;
                for (int i = 0; i < ca.Length; i++)
                {
                    if (ca[i] == cp1)
                    {
                        cpa = i;
                    }
                    else if (ca[i] == cp2)
                    {
                        cpa2 = i;
                    }
                }
                if(cpa < cpa2)
                {
                    Console.WriteLine(ca[cpa]);
                }
                else
                {
                    Console.WriteLine(ca[cpa2]);
                }
            }
        }   
    }
}