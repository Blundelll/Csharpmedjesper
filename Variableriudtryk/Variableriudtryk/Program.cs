using System;

namespace Variableriudtryk
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 50;
            int num2 = 65;
            int result = num1 - num2;

            Console.Write(num1);
            Console.Write(" - ");
            Console.Write(num2);
            Console.Write(" = ");
            Console.WriteLine(result);
            Console.ReadKey();



            Console.Clear();

            //Øvelse 1

            int et = 1;
            int to = 2;
            int tre = 3;
            int result2 = et + to + tre;
            Console.Write(result2);
            Console.ReadKey();

            Console.Clear();

            //Øvelse 2

            int result3 = result + result2 + num1 * num2 / et % tre;
            Console.Write(result3);
            Console.ReadKey();


        }
    }
}
