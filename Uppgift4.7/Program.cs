using System;
namespace Uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett meddelnade?");
            string meddelande = Console.ReadLine();
            Console.WriteLine("Hur många steg åt höger ska meddelandet vara?");
            string stegtext = Console.ReadLine();
            int steg = int.Parse(stegtext);
            
            for (int i = 0; i < meddelande.Length; i++)
            {
                for (int j = 0; j < steg; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(meddelande[i]);
            }
            Console.ReadKey();
        }
    }
}