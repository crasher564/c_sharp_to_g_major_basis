using System.Collections.Generic;
namespace opdracht18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 18");

            klant marijk= new klant();

            List<klant> klanten = marijk.Initialiseer();

            foreach (klant k in klanten)
            {
                Console.WriteLine(k.PrintKlant());
            }
        }
    }
}
