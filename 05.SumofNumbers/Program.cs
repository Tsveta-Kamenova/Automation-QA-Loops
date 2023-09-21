namespace _05.SumofNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());
            int currentSum = 0;

            while  (currentSum < targetSum)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                currentSum += currentNumber;
            }
            Console.WriteLine(currentSum);
        }
    }
}