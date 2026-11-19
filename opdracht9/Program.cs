namespace opdracht9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 9");
            Console.WriteLine("Kies 1, 2 of 3:");
            int keuze = int.Parse(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    Console.WriteLine("$ 2,00");
                    break;
                case 2:
                    Console.WriteLine("$ 2,50");
                    break;
                case 3:
                    Console.WriteLine("$ 3,00");
                    break;
                default:
                    Console.WriteLine("Ongeldige keuze");
                    break;
            }
            Console.ReadLine();
        }
    }
}
