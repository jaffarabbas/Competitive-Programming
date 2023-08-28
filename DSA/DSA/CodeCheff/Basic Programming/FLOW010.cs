using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.CodeCheff.Basic_Programming
{
    internal class FLOW010
    {
        public static void func()
        {
            int t = int.Parse(Console.ReadLine());
            while ((t--) > 0)
            {
                char a = Char.Parse(Console.ReadLine());
                if(a == 'B' || a == 'b')
                {
                    Console.WriteLine("BattleShip");
                }else if(a == 'C' || a == 'c')
                {
                    Console.WriteLine("Cruiser");
                }else if(a == 'D' || a == 'd')
                {
                    Console.WriteLine("Destroyer");
                }else if(a == 'F' || a == 'f')
                {
                    Console.WriteLine("Frigate");
                }
            }
        }
    }
}
