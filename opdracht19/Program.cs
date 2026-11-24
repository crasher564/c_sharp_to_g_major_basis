using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace opdracht18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 18");
            klant marijk = new klant();

            List<klant> klanten = marijk.Initialiseer();
            var gesorteerd = klanten.OrderBy(k => k.Naam);
            var filterdlist = gesorteerd
            .Where(k => k.Phone.StartsWith("0612345"))
            .ToList();
            var aantal = gesorteerd
            .Where(k => k.Phone.StartsWith("0612345"))
            .Count();
            var eersteklant = gesorteerd
            .Where(k => k.Phone.StartsWith("0612345"))
            .First();

            Console.WriteLine($"er zijn {aantal} geldige klanten");
            Console.WriteLine($"de eerste klant is {eersteklant}");
            foreach (klant k in filterdlist)
            {
                Console.WriteLine(k.PrintKlant());
            }
        }
    }
}

