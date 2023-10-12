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

            //string command = Console.ReadLine();

            //while (command != "End")
            //{
            //    int numberToProcess = int.Parse(command);
            //    int sum = 0;

            //    // 13546
            //    // 1354
            //    // 135
            //    // 13
            //    // 1
            //    // 0

            //    for (int number = numberToProcess; number > 0; number /= 10)
            //    {
            //        int digit = number % 10;
            //        sum += digit;
            //    }

            //    Console.WriteLine($"Sum of digits = {sum}");

            //    command = Console.ReadLine();
            //}

            //Console.WriteLine("Goodbye");
        }
    }
}