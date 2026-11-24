namespace opdracht17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 17");

            Console.Write("hoe lang is array : ");

            string invoer = Console.ReadLine();

            int getal;

            if (int.TryParse(invoer, out getal))
            {
                int length = int.Parse(invoer);

                    string[] numb = new string[length];

                    for (int i = 0; i < numb.Length;)
                    {
                        Console.Write("enter a new number : ");

                        string num = Console.ReadLine( );

                        if (int.TryParse(num, out getal) == true)
                        {
                            numb[i] = num;
                            i++;
                            Console.WriteLine($"{length - i} left");
                        }
                    else
                    {
                        Console.WriteLine("not a valid awnser :3");
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
