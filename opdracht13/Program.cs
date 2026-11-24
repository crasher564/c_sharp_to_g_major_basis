namespace opdracht13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 13");


            int getal;
            string[] numb = new string[5];

            for (int i = 0; i < numb.Length; )
            {
                Console.WriteLine("enter a new number");
                string num = Console.ReadLine();
                if (int.TryParse(num, out getal) == true)
                {
                    numb[i] = num;
                    i++;
                }
                else
                {
                    Console.WriteLine(" dat is geen nummer");
                }
            }
            for (int i = 0; i < numb.Length; i++)
            {
                Console.WriteLine(numb[i]);
            }
        }
    }
}
