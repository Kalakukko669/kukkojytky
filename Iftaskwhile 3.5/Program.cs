using System;

namespace Iftaskwhile_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int i = 0;
            int EvenSum = 0;
            int OddSum = 0;
            Console.WriteLine("Ohjelma laskee N parilisten ja parittomien lukujen summan!");
            Console.Write("Syötä luku:");
            N = int.Parse(Console.ReadLine());

            while (i !=N)
            {

                if (N>0)
                {                    
                    i = i + 1;
                }
                else
                {     
                    i = i -1;
                }
                if (i % 2==0)
                {
                    EvenSum += i;
                }
                else
                {
                    OddSum += i;                                                
                }
            }
            Console.WriteLine("Parillisten summa on " + EvenSum);
            Console.WriteLine("Parittomien summa on " + OddSum);
        }
    }
}
