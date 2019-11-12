using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Random rnd = new Random();
            Console.WriteLine("Ohjelma simuloi heitettyjen kruunujen ja klaavojen määrä");
            Console.Write("Kuinka monta kertaa heität kolikkoa?");
            n = int.Parse(Console.ReadLine());
            int r = 0;
            int kruuna = 0;
            int klaava = 0;

            for(int i=0;i<n;i++)
            {
                r = rnd.Next(0, 2);

                if (r == 1)
                {
                    klaava++;
                }
                else
                {
                    kruuna++;
                }
          
                       
            }

            Console.WriteLine($"Rahaa on heitetty {n}.\tKlaavoja tuli { klaava } ja Kruunuja tuli {kruuna

        }
    }
}

