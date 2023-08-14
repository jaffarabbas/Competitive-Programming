using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeForces._1794
{
    internal class A
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int l = int.Parse(Console.ReadLine());
                string[] lines = Console.ReadLine().Split(' ');
                int fl = lines.Length / 2;
                string[] par = new string[fl];
                string[] por = new string[lines.Length - fl];
                Array.Copy(lines, 0, par, 0, fl);
                Array.Copy(lines, fl, por, 0, lines.Length - fl);
                if (par.Equals(por))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
