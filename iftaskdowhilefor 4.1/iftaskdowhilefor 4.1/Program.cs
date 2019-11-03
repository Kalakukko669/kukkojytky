using System;

namespace iftaskdowhilefor_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Console.WriteLine("Tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret");
            Console.WriteLine("Luku\nNeliöjuuri");
            while (N< 9)
            {
                N++;
                Console.WriteLine($"  {N+ 1}\t{Math.Sqrt(N+ 1)}");
            }                       
        }

    }
}
