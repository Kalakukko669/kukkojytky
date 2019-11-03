using System;

namespace Funktio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma palauttaa käyttäjän syöttämän luvun arvoisen määrän *** ");
            int userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber < 0)
            {
                Console.WriteLine("virheellinen syöttö");
            }
            else
            {

            }
           
        }
    }
}
