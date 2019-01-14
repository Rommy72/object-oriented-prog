using System;

namespace Cat
{
    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Tämä on kissaohjelma ... ");

                Cat my1StCat = new Cat(" Pilli", 1);
                my1StCat.IncreaseWeight(1);
                Cat my2DNcat = new Cat(" Pulla", 3);
                my2DNcat.PrintWeight();

                Console.Write("Painahan mitä vaan näppylää...\n");
                Console.ReadKey();

            }
        }
    }


    

