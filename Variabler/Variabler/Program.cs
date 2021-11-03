using System;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assinged Variable
            int gradeMads;
            gradeMads = 12;

            // Student Jesper & Kevin
            int gradeJesper = 7; // Declare 
            int gradeKevin = 10;


            Console.Write("Mads fik: ");
            Console.WriteLine(gradeMads);
            Console.Write("Jesper fik: ");
            Console.WriteLine(gradeJesper);

            Console.Write("Kevin fik: ");
            Console.WriteLine(gradeKevin);
            Console.ReadKey();


            // Øvelse
            Console.Clear(); // clear consolen
            int x = 5;
            int y = 3;

            // $ foran "" så du kan set viable ind med {}
            Console.Write($"x er {x} og y er {y} ");
            Console.ReadKey();
            

        }
    }
}
