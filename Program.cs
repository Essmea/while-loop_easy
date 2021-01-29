using System;

namespace Meny
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ett_till_tre = true;
            while (ett_till_tre)
            {
                Console.WriteLine("Välj 1 för att välja ett");
                Console.WriteLine("Välj 2 för att välja två");
                Console.WriteLine("Välj 3 för att välja tre och avsluta programmet");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                    Console.WriteLine("Du valde ett!");

                else if (input == 2)
                    Console.WriteLine("Du valde två! Bra jobbat!");

                else
                    ett_till_tre = false; //falskt = stänger av programmet 
            
            }

        }
    }
}
