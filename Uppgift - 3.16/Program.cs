using System;

 namespace Uppgift_3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är låten?");
            int svar = int.Parse (Console.ReadLine());
            if (svar >= 240 && svar <= 420)
            {
                Console.WriteLine("Du får spela låten");
                

            }
            else
            {
                Console.WriteLine("Du får inte spela låten");
            }
        }
    }
}

    
