namespace _67.SumOfDigitsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine() ?? "1";
            int sumDigits = 0;

            while (number != "End") 
            {
                for (int digit = 0; digit < number.Length; digit ++)
                {
                    string currentDigit = number[digit].ToString();

                    sumDigits += int.Parse(currentDigit);
                }
                Console.WriteLine($"Sum of digits = {sumDigits}");
                sumDigits = 0;
                number = Console.ReadLine() ?? "1";
            }
            Console.WriteLine("Goodbye");
        }
    }
}