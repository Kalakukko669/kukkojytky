using System;

namespace iftaskdowhilefor_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double r = 0;
            
            Console.WriteLine("Ohjelma tulostaa vakio veikkauksen 13 kohdetta");

            for (int i = 0; i < 13; i++)
            {
                r= rnd.NextDouble();
              

                if ( r<=0.4)
                {
                    Console.WriteLine("1");                   
                }
                else
                {
                    
                }
                if (r > 0.4 && r < 0.6)
                {
                    Console.WriteLine("x");
                }
                else
                {

                }
                if (r >= 0.6)
                {
                    Console.WriteLine("2");
                }

            }
            
            
        }
    }
}
