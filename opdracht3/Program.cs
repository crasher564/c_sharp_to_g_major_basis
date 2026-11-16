namespace opdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 3");
            string invoer = "42";
            int getal = int.Parse(invoer);
            int resultaat = getal * 2;
            Console.WriteLine("Het dubbele is: " + resultaat);
            Console.WriteLine("het is 84 want 42 keer 2 is 84");

            Console.ReadLine();

        }
    }
}
