namespace opdracht13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 13");

            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("enter a new number");
                int naam = int.Parse(Console.ReadLine());
                if (naam >= 0 && naam <= 9)
                {
                    num[i] = naam;
                }
                else
                {
                    i = 0;
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
