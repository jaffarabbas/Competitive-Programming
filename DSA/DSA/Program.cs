﻿
using System;

namespace DSA 
{
    internal class Program
    {
        public static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while (t-- > 0)
            {
                int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
                if (l[0] % l[1] == 0)
                {
                    Console.WriteLine(l[0] / l[1]);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
        }   
    }
}