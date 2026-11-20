namespace opdracht6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 6");

            int huidig_jaar = DateTime.Now.Year;
            int huidig_maand = DateTime.Now.Month;
            int huidig_dag = DateTime.Now.Day;

            Console.WriteLine("geboorte jaar?");
            int geboorte_jaar = int.Parse(Console.ReadLine());
            Console.WriteLine("geboorte month?");
            int geboorte_maand = int.Parse(Console.ReadLine());
            Console.WriteLine("geboorte dag?");
            int geboorte_dag = int.Parse(Console.ReadLine());
 
            Console.WriteLine($"geweldig!, jij bent {huidig_jaar - geboorte_jaar} jaar, " +
                $"{huidig_maand - geboorte_maand} maanden " +
                $"en {huidig_dag - geboorte_dag} dagen oud, gefeliciteerd!");

            if (huidig_jaar - geboorte_jaar >= 50) 
            {
                if (huidig_jaar - geboorte_jaar >= 75)
                {

                    Console.WriteLine("have you considerd buying a coffin?");
                }
                else
                {
                    Console.WriteLine("wow you old");
                }
            }
            else
            {
                Console.WriteLine("geniet verder van je leven");
            }
            Console.ReadLine();
        }
    }
}
