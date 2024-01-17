using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class EXPERT
    {
        public static void func()
        {
            //int t = int.Parse(Console.ReadLine());
            //while (t-- > 0)
            //{
            //    int[] l = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            //    float a = (l[1] / l[0]);
            //    Console.WriteLine(a * 100 >= 50 ? "YES" : "NO");
            //}
            int TotalProblems = Convert.ToInt32(Console.ReadLine());
            while (TotalProblems-- > 0)
            {
                string[] Problems = Console.ReadLine().Split(' ');
                int X = int.Parse(Problems[0]);
                int Y = int.Parse(Problems[1]);
                double approvalPercentage = (double)Y / X * 100;
                string Result = (approvalPercentage >= 50) ? "YES" : "NO";
                Console.WriteLine(Result);
            }
        }
    }
}
