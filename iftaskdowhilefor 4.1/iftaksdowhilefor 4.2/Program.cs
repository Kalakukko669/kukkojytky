using System;

namespace iftaksdowhilefor_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa lukujen 1-9 kertotaulun");
            for (int i =1; i <= 9; i++)
            {
                for (int j =1; j <= 9; j++)
                {                   
                    Console.WriteLine($" {i}*{j}={i*j}");
                }
            }            
        }       
    }
}
