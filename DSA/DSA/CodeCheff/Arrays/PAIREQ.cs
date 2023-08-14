using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DSA.CodeCheff.Arrays
{
    internal class PAIREQ
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                int max = 0;
                int l = int.Parse(Console.ReadLine());
                string[] lines = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(lines, int.Parse);
                Dictionary<int, int> dic = new Dictionary<int, int>();
                //use for checking frequencies of each array element
                foreach (var i in arr)
                {
                    if (dic.ContainsKey(i))
                    {
                        dic[i]++;
                    }
                    else
                    {
                        dic.Add(i, 1);
                    }
                }
                foreach (var i in dic.Values)
                {
                    if(i > max)
                    {
                        max = i;
                    }
                }
                Console.WriteLine(l-max);
                t--;
            }
        }
    }
}
