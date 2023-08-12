using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeForces._1850
{
    internal class C
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string v = "";
                string[] arr = new string[8];
                for (int i = 0; i < 8; i++)
                {
                    arr[i] = Console.ReadLine();
                }
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        string temp = arr[i][j].ToString();
                        if (!temp.Equals("."))
                        {
                            v += arr[i][j];
                        }
                    }
                }
                Console.WriteLine(v);
                t--;
            }
        }
    }
}
