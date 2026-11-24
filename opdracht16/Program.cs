namespace opdracht16
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int getal;
            while (true)
            {
                Console.WriteLine("number 1");
                string getal1 = Console.ReadLine();
                if (int.TryParse(getal1, out getal))
                {
                   int getal4 = int.Parse(getal1);
                    Console.WriteLine(" number 2");
                    string getal2 = Console.ReadLine();
                    if (int.TryParse(getal2, out getal))
                    {
                        int getal5 = int.Parse(getal2);
                        Console.WriteLine("math type");
                        string getal3 = Console.ReadLine();
                        if (int.TryParse(getal3, out getal))
                        {
                            int getal6 = int.Parse(getal3);
                            int uitkomst = Optellen(getal4, getal5, getal6);

                            Console.WriteLine("De som is: " + uitkomst);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ongeldige keuze. Voer 1, 2, 3 in");
                        }
                    }
                    else
                    {
                        Console.WriteLine("invalide");
                    }
                }
                else
                {
                    Console.WriteLine("invalide");
                }
            }
        }
        public static int Optellen(int getal4, int getal5, int getal6)
        {
            if (getal6 == 1)
            {
                return getal4 + getal5;
            }
            if (getal6 == 2)
            {
                return getal4 - getal5;
            }
            if (getal6 == 3)
            {
                return getal4 * getal5;
            }
            if (getal6 == 4)
            {
                return getal4 / getal5;
            }
            return 0;
        }
    }
}
