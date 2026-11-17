namespace opdracht5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 5");
            Console.WriteLine("rechthoek lengte?");
            int lengte = int.Parse(Console.ReadLine());
            Console.WriteLine("rechthoek breedte?");
            int breedte = int.Parse(Console.ReadLine());
            int opervlakte = lengte * breedte;
            Console.Write(opervlakte);
        }
    }
}
