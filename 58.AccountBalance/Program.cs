namespace _58.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string depositAmountInput = Console.ReadLine();

            double totalAmount = 0.0;

            while (depositAmountInput != "End")
            {
                double depositAmount = double.Parse(depositAmountInput);
                totalAmount += depositAmount;

                if (depositAmount < 0)
                {
                    Console.WriteLine($"Decrease: {Math.Abs(depositAmount):F2}");
                }
                else
                {
                    Console.WriteLine($"Increase: {depositAmount:F2}");
                }

                depositAmountInput = Console.ReadLine();
            }

            Console.WriteLine($"Balance: {totalAmount:F2}");
        }
    }
}