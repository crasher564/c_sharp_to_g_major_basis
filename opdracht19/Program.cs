using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace opdracht19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 18");
            klant marijk = new klant();

            List<klant> klanten = marijk.Initialiseer();
            var gesorteerd = klanten
            .Where(k => k.Phone.StartsWith("0612345")).OrderBy(k => k.Naam)
            .ToList();
            var aantal = gesorteerd
            .Count();
            var eersteklant = gesorteerd
            .First();

            Console.WriteLine($"er zijn {aantal} geldige klanten");
            Console.WriteLine($"de eerste klant is {eersteklant}");
            foreach (klant k in gesorteerd)
            {
                Console.WriteLine(k.PrintKlant());
            }
        }
    }
}

