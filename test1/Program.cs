using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            var kvadrat = new Kvadrat();
            Console.Write("massivin uzunlugunu daxil et:");
           
            
            int n = int.Parse(Console.ReadLine());
            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                mass[i] = int.Parse(Console.ReadLine());
            }
            
            var getSqrtElements = kvadrat.GetSqrtElements(mass);
            kvadrat.Print(getSqrtElements);

            

            #endregion

            #region Task 2
            //var reverse = new Reverse();

            //Console.Write("eded daxil edin:");
            //int number = int.Parse(Console.ReadLine());

            //int reversenumber = reverse.Number(number);
            //Console.WriteLine(reversenumber);
            #endregion


        }
    }
}
