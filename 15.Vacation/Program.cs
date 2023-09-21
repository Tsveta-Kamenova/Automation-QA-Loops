namespace _15.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            double sumSaved = availableMoney;
            double sumSpent = 0;

            int counterSpending = 0;
            int counterTotalDays = 0;


            while (counterSpending < 5 && sumSaved < neededMoney) 
            {
                string actionType = Console.ReadLine();
                double amountToSaveSpend = double.Parse(Console.ReadLine());
                counterTotalDays++;

                if (actionType == "spend")
                {
                    sumSpent += amountToSaveSpend;
                    sumSaved -= amountToSaveSpend;

                    if (sumSaved < 0) sumSaved = 0;

                    counterSpending ++;
                }
                else if (actionType == "save")
                {
                    sumSaved += amountToSaveSpend;
                    counterSpending = 0;
                }
            }    

            if (counterSpending == 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{counterTotalDays}");
            }
            else if (sumSaved >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {counterTotalDays} days.");
            }

        }
    }
}