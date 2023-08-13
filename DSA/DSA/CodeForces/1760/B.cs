using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeForces._1760
{
    internal class B
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int count = 0;
                int n = int.Parse(Console.ReadLine());
                char a = char.Parse(Console.ReadLine());
                char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                for (int i = 0;  i < arr.Length; i++)
                {
                    if(a == arr[i])
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
