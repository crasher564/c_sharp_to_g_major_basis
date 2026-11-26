namespace opdracht20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opdracht 20");
            List<double> numbers = new List<double>();
            int getal;
            while (true)
            {
                string i = Console.ReadLine();
                if (i == "stop")
                {
                    break;
                }
                else
                {
                    if (int.TryParse(i, out getal));
                    {
                        try
                        {
                            double true_i = double.Parse(i);
                            if (true_i >= 0 && true_i <= 10)
                            {
                                numbers.Add(true_i);
                            }
                            else
                            {
                                Console.WriteLine("not the right size");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("not the right format");
                        }
                    }
                }
            }
            var orderd = numbers.OrderByDescending(k => k);
            var gemideld = orderd.Average();
            var highest = orderd.Max();
            var lowest = orderd.Min();
            var voldoendes = orderd.Where(k => k >= 5.5)
                .Count();
            Console.WriteLine($" het gemidelde is {gemideld}");
            Console.WriteLine($" het hoogste is {highest}");
            Console.WriteLine($" het laagste is {lowest}");
            Console.WriteLine($"er zijn {voldoendes} voldoendes");
            foreach (double k in orderd)
            {
                Console.WriteLine(k);
            }

        }
    }
}
