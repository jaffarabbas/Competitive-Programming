using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Other
{
    internal class IntegerFunctions
    {
        public static int getFirstInt(int num)
        {
            while(num > 10)
            {
                num /= 10;
            }
            return num;
        }

        public static int getIntAtIndex(int num,int index)
        {
            double l = Math.Pow(10,index);
            return num % (int)l;
        }

        public static int getLastInt(int num)
        {
            return num % 10;
        }
        public static int counterIntegerWithOutString(int num)
        {
            int len = 0;
            while(num > 0)
            {
                num /= 10;
                len++;
            }
            return len;
        }
    }
}
