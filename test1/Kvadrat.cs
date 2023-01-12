using System;
using System.Collections.Generic;
using System.Text;

namespace test1
{
    class Kvadrat

    {
        internal int[] GetSqrtElements(int[] mass)
        {
            
            
            int count = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (Math.Sqrt(mass[i]) == (int)Math.Sqrt(mass[i]))
                    count++;
            }
            int[] sqrtElements = new int[count];
            int index = 0;
            for (int i = 0; i <mass.Length ; i++)
            {
                if (Math.Sqrt(mass[i]) == (int)Math.Sqrt(mass[i])) 
                {
                    sqrtElements[index++] = mass[i];

                }

            }return sqrtElements;
        }
        internal void Print(int[] mass)
        {
            foreach (var item in mass)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
