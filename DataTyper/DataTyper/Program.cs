using System;

namespace DataTyper
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, float, doubleog en char
            int myInt = -150; //hele tal
            double myDouble = -40.321; //komma tal
            char myChar = 'a'; //bogstaver

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myChar);
            Console.ReadKey();


            Console.Clear();

            //Øvelse 1
            double double2 = 22.22;
            char char2 = 'e';
            int int2 = 22;

            Console.WriteLine(double2);
            Console.WriteLine(char2);
            Console.WriteLine(int2);
            Console.ReadKey();



            Console.Clear();

            //Øvelse 2
            Console.WriteLine("float er 32 bit og double er 64 bit så double kan brug flere tal end float men tager flere bytes");


            Console.Clear();

            //Øvelse 3
            int T31 = 1054;
            int TT31 = -522;
            double H31 = 1.234;
            char B31 = 'k';
            double HH31 = -4.3;
            char BB31 = 'y';
            int TTT31 = 19488;


            Console.Write($"{T31}, {TT31}, {H31}, {B31}, {HH31}, {BB31}, {TTT31}");
            Console.ReadKey();


        }
    }
}
