using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string lille og stor er det samme
            string hello = "hello console";
            Console.WriteLine(hello);
            Console.ReadKey();





            Console.Clear();

            //Øvelse 1
            string hej = "Hej med dig. Jeg er en smart variabel type!";
            Console.WriteLine(hej);
            Console.ReadKey();

            Console.Clear();

            //Øvelse 2

            string november = "I dag har vi den 20 november";
            Console.WriteLine(november);
            Console.ReadKey();

            Console.Clear();

            //Øvelse 3

            double penge = 200.50;
            string jeg = "jeg har";
            string kr = "kr. i banken";

            Console.Write($"{jeg} {penge} {kr}");
            Console.ReadKey();



        }
    }
}
