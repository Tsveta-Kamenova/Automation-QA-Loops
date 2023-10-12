using System.Threading.Channels;

namespace _66.TravelSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumMoney = 0;

            string destination = Console.ReadLine() ?? "0";
            int neededBudget = int.Parse(Console.ReadLine() ?? "0");
            string input = Console.ReadLine() ?? "0";

            while (input != "End")
            {
                int collectedMoneyInt = int.Parse(input);
                sumMoney += collectedMoneyInt;
                Console.WriteLine($"Collected: {sumMoney:f2}");

                if (sumMoney >= neededBudget)
                {
                    Console.WriteLine($"Going to {destination}!");
                    destination = Console.ReadLine() ?? "0";
                    if (destination == "End")
                    {
                        break;
                    }
                    neededBudget = int.Parse(Console.ReadLine() ?? "0");
                    sumMoney = 0;
                }

                input = Console.ReadLine() ?? "0";
            }

        }
    }
}