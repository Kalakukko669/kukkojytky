using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int i = 1;
            int Summa = 0;
            
            Console.WriteLine("Ohjelma laskee lukua N yhteen");
            Console.Write("syötä luku:");
            N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("Virheellinen syöte");
            }
            else
            {
                while ( i<=N)
                {
                    Summa = Summa + i;
                    i = i + 1;
                }
                Console.WriteLine("Vastaus" + Summa );
            }
        }
    }
}
