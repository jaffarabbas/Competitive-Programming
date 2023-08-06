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
