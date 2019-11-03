using System;

namespace iftaskwhilefor3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int F = 1;
            Console.WriteLine("Ohjelma selvitää N kertoman arvon");
            Console.Write("syötä luku:");
            N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("Virheellinen syöte!");
            }
            else
            {
                while (N > 0)
                {
                    F = F * N;
                    N = N - 1;
                }
                Console.WriteLine("Vastaus " + F);
            }
        }
    }
}
