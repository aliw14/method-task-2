using System;
using System.Collections.Generic;
using System.Text;

namespace test1
{
    class Reverse
    {
        internal int Number(int number)
        {
            int reversenumber = 0;
            int r;
            int count = (int)Math.Log10(number);

            while (number != 0)
            {
                r = number % 10;
                number /= 10;
                reversenumber += r * (int)Math.Pow(10, count);
                count--;
            }

            return reversenumber;
        }
    }
}
