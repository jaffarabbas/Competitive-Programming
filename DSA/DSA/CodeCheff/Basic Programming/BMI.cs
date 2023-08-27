using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class BMI
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                string[] lines = Console.ReadLine().Split(" ");
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                //squre
                for (int i = 1; i <= b; i++)
                {
                    b *= b;
                }
                int bmi = a / b;
                if(bmi <= 18)
                {
                    Console.WriteLine(1);
                }else if (bmi >= 19 && bmi <= 24)
                {
                    Console.WriteLine(2);
                }else if (bmi >= 25 && bmi <= 29)
                {
                    Console.WriteLine(3);
                }else if(bmi >= 30)
                {
                    Console.WriteLine(4);
                }
            }
        }
    }
}
