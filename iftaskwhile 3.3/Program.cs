using System;

namespace iftaskwhile_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int i = 1;
            int EvenSum = 0;
            int OddSum = 0;
            Console.WriteLine("Ohjelma laskee N parilisten ja parittomien lukujen summan!");
            Console.Write("Syötä luku:");
            N = int.Parse(Console.ReadLine());

            while (i<=N )
            {
                if (i % 2 == 0)
                {
                    EvenSum = EvenSum + i;
                    i = i + 1;
                }
                else
                {
                    OddSum = OddSum + i;
                    i = i + 1;
                }
            }
            Console.WriteLine("Parillisten summa on "+ EvenSum);
            Console.WriteLine("Parittomien summa on" + OddSum);
                
        }
    }
}
