using System;

namespace iftaskdowhilefor_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0-50 ");
            Random rnd = new Random();
            int y = 0;
            do
            {
                y++;
                Console.WriteLine($"Rivi\t{y}:\t{rnd.Next(50)},{rnd.Next(50)},{rnd.Next(50)},{rnd.Next(50)},{rnd.Next(50)}");                
            } while (y < 4);
        }
    }
}
