namespace opdracht15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 15");

            Console.WriteLine("number 1");

            int getal1 = int.Parse(Console.ReadLine())
                ;
            Console.WriteLine(" number 2");
            int getal2 = int.Parse(Console.ReadLine());

            int uitkomst = Optellen(getal1, getal2);

            Console.WriteLine("De som is: " + uitkomst);
        }
        public static int Optellen(int getal1, int getal2)
        {
            return getal1 + getal2;
        }
        

    }
}
