using System;

namespace itsearviointi_tehtävä_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä sana:");
            int i = int.Parse(Console.ReadLine());
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"{j}.{i}");
            }
        }
    }
}
