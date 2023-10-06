namespace _44.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int sumDigits = 0;

            while (number > 0)
            {
                int digit = number % 10; // Get the last digit
                sumDigits += digit; // Add the digit to the sum
                number /= 10; // Remove the last digit
            }

            Console.WriteLine($"{sumDigits}");


            //string input = Console.ReadLine();

            //int sum = 0;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    char digitChar = input[i];

            //    if (char.IsDigit(digitChar))
            //    {
            //        int digit = digitChar - '0'; // Convert character to integer
            //        sum += digit; // Add the digit to the sum
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a positive integer.");
            //        return;
            //    }
            //}

            //Console.WriteLine($"{sum}");
        }
    }
}