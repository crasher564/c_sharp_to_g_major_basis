namespace opdracht8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 8");

            string toets = Console.ReadLine();
            string lucky = "lucky";

            string resultaat = (toets == lucky) ? " is correct " : " is fout ";
            Console.Write(resultaat);
        }
    }
}
