namespace opdracht17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 17");

            Console.WriteLine("Voer een getal in:");
            string invoer = Console.ReadLine();
            int getal;
            if (int.TryParse(invoer, out getal))
            {
                int invoer2 = int.Parse(invoer);
                    string[] numb = new string[invoer2];

                    for (int i = 0; i < numb.Length;)
                    {
                        Console.WriteLine("enter a new number");
                        string num = Console.ReadLine( );
                        if (int.TryParse(num, out getal) == true)
                        {
                            numb[i] = num;
                            i++;
                            Console.WriteLine($"{invoer2 - i} left");
                        }
                    }
                    for (int i = 0; i < numb.Length; i++)
                    {
                        Console.WriteLine(numb[i]);
                    }
            }
            else
            {
                Console.WriteLine("not a valid awnser :3");
            }
        }
    }
}
