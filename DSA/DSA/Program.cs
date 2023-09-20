
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
                string[] lines = Console.ReadLine().Trim().Split(" ");
                int[] arr = Array.ConvertAll(lines, int.Parse);
                int count = 0, count2 = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i%2 == 0)
                    {
                        count+=arr[i];
                    }
                    else
                    {
                        count2 += arr[i];
                    }
                }
                if (count > count2)
                {
                    Console.WriteLine(1);
                }
                else if (count < count2)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }   
    }
}