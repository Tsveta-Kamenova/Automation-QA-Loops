namespace _00.JustATest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            double price = 0;


            if (season == "Summer")
                price = 4200;
            else if (season == "Spring")
                price = 3000;
            else if (season == "Autumn")
                price = 4200;
            else if (season == "Winter")
                price = 2600;

            if (fishermenCount <= 6)
                price = price * 0.9;
            else if (fishermenCount >= 7 && fishermenCount <= 11)
                price = price * 0.85;
            else if (fishermenCount >= 12)
                price = price * 0.75;

            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                price = price * 0.95;
            }

            if (price <= budget)
                Console.WriteLine($"Yes! You have {(budget - price):f2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {(price - budget):f2} leva.");
        }
    }
}