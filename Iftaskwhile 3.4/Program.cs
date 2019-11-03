using System;

namespace Iftaskwhile_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int i = 0;
            int Summa = 0;

            Console.WriteLine("Ohjelma laskee lukua N yhteen");
            Console.Write("syötä luku:");
            N = int.Parse(Console.ReadLine());

            if (N==0)
            {
                Console.WriteLine("Virheellinen syöte");
            }
            else
            {
                while (i != N) 
                {
                    if (i > 0)
                    {
                        i = i + 1;
                        Summa = Summa + i;
                    }
                    else
                    {
                        i = i - 1;
                        Summa = Summa + i;
                    }
                                          
                }
                Console.WriteLine("Vastaus" + Summa);
            }
            
        }
    }
}
