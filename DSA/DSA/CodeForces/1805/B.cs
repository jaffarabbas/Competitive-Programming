using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeForces._1805
{
    internal class B
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                int a = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                string rearrangedString = "";
                char target = '\0'; // Initialize to a default value
                int targetIndex = -1;
                for (int i = a - 1; i > 0; i--)
                {
                    if (s[i] < s[i - 1])
                    {
                        target = s[i];
                        targetIndex = i;
                        break;
                    }
                }
                if (target != '\0')
                {
                    rearrangedString = target + s.Remove(targetIndex, 1);
                }
                Console.WriteLine(rearrangedString);
            }
        }
    }
}
