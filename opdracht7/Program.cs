namespace opdracht7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 7");

            Console.WriteLine("guess a number: ");

            ConsoleKeyInfo toets = Console.ReadKey();

            if (toets.KeyChar >= '0' && toets.KeyChar <= '9')
            {
                if (toets.KeyChar == 5)
                {
                    Console.WriteLine(" dit is het goede nummer");
                }
                else
                {
                    Console.WriteLine(" guess again :3 ");
                }
            }
            else
            {
                Console.WriteLine(" guess a number :3 ");
            }
        }
       
    }
}
