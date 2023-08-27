using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class VOWELTB
    {
        public static void func()
        {
            char a = Char.Parse(Console.ReadLine());
            if(a == 'A' || a == 'E' || a== 'I' || a == 'O' || a == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }
    }
}
