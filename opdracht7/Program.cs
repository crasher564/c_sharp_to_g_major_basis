namespace opdracht7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 7");

            Console.Write("guess a number: ");
            ConsoleKeyInfo input = Console.ReadKey();
                if (input.KeyChar == 5)
                {
                    Console.WriteLine(" dit is het goede nummer");
                }
                else
                {
                    Console.WriteLine(" ander nummer :3");
                }
        }
       
    }
}
