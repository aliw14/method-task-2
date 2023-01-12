using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var reverse = new Reverse();

            Console.Write("eded daxil edin:");
            int number = int.Parse(Console.ReadLine());

            int reversenumber = reverse.Number(number);
            Console.WriteLine(reversenumber);

        }
    }
}
