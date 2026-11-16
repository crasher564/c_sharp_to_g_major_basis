namespace opdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 4");
            int a = 2;
            if (a < 5)
            {
                Console.WriteLine($"a is {a}");
                Console.WriteLine("het is binnen bereik");
            }
            else
            {
                Console.WriteLine($"a is {a}");
                Console.WriteLine("het is  buiten bereik");
            }
            Console.ReadLine();
        }
    }
}
