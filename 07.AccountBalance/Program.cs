namespace _07.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string depositAmountInput = Console.ReadLine();
            
            double totalAmount = 0.0;

            while (depositAmountInput != "NoMoreMoney") 
            {
                double depositAmount = double.Parse(depositAmountInput);

                if (depositAmount < 0 )
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    totalAmount += depositAmount;
                    Console.WriteLine($"Increase: {depositAmount:F2}");
                }

                depositAmountInput = Console.ReadLine();
            }

            Console.WriteLine($"Total: {totalAmount:F2}");
        }
    }
}