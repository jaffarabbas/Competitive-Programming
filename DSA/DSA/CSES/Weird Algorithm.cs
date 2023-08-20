using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CSES
{
    internal class WeirdAlgorithm
    {
        public static void func()
        {
            int n = int.Parse(Console.ReadLine());  
            while(n >= 1)
            {
                if(n%2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = (n * 3) + 1; 
                }
                Console.WriteLine(n+" ");
            }
        }
    }
}
