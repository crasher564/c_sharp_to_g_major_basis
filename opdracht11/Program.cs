namespace opdracht11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 11");
            Console.WriteLine("menu selector");
            while (true)
            {
                ConsoleKeyInfo number = Console.ReadKey();
                if (number.KeyChar == '1')
                {
                    Console.WriteLine(" menu 1");
                }
                if (number.KeyChar == '2')
                {
                    Console.WriteLine(" menu 2");
                }
                if (number.KeyChar == '3')
                {
                    break;
                }
            } 
        }
    }
}
