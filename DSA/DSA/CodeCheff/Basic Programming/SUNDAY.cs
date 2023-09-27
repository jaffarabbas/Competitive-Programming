using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class SUNDAY
    {
        public static void func()
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                int N = int.Parse(Console.ReadLine());
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int holiday = 8;
                for (int j = 0; j < N; j++)
                {
                    if (arr[j] != 6 && arr[j] != 7 && arr[j] != 13 && arr[j] != 14 && arr[j] != 20 && arr[j] != 21 && arr[j] != 27 && arr[j] != 28)
                    {
                        holiday++;
                    }
                }
                Console.WriteLine(holiday);
            }
        }
    }
}
