using System;

namespace DSA // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int count = 0;
                int n = int.Parse(Console.ReadLine());
                string a = Console.ReadLine();
                char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                string f = String.Concat(a.OrderBy(c => c));
                for (int i = 0; i < arr.Length; i++)
                {
                    count++;
                    if (f.Last() == arr[i])
                    {
                        break;
                    }
                }
                Console.WriteLine(count);
                t--;
            }
        }   
    }
}