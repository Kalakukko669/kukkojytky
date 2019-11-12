using System;

namespace iftaskdowhilefor_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma demostroi nopan heittoa 1000 kertaa ja tulostaa kuutosten lisääntymis määrän");
            Random rnd = new Random();
            int r = 0;
            int s = 0;
            for(int i = 0; i < 1001; i++)
            {
                
                r = rnd.Next(1, 7);
                if (r == 6)
                {
                    Console.WriteLine($"{r}");
                    s++;
                }
                else
                {
                    Console.WriteLine($"{r}");
                }
                
            }

            Console.WriteLine($"Kuutos heitto määrä tuhannesta {s}");
            
        }
    }
}
