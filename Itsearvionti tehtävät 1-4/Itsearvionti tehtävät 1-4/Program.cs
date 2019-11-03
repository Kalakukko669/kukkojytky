using System;

namespace Itsearvionti_tehtävät_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä sana:");
            string i= Console.ReadLine();
            for(int j = 0; j < 5; j++)
            {
                Console.WriteLine($"{j}.{i}");
            }          
        }
    }
}
