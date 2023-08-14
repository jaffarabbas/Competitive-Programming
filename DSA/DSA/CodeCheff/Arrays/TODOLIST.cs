using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Arrays
{
    internal class TODOLIST
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int l = int.Parse(Console.ReadLine());
                int count = 0;
                string[] arr = Console.ReadLine().Split(' ');

                for (int i = 0; i < arr.Length; i++) { 
                    int v = int.Parse(arr[i]);
                    if (v >= 1000) 
                    {
                        count++;    
                    }
                }
                Console.WriteLine(count);
                t--;
            }
        }
    }
}
