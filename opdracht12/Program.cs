namespace opdracht12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 12");

            string[] namen = new string[5];

            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine("enter a new name");
                string naam = Console.ReadLine();
                namen[i] = naam;
            }
            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine(namen[i]);
            }
        }
    }
}
