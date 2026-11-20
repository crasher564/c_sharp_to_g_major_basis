namespace opdracht10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 10");

            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
    }
}
