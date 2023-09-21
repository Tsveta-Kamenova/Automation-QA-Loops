namespace _23.SumOfPrimeAndNon_PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "stop")
                {
                    break; // Exit the loop when "stop" is entered
                }

                if (int.TryParse(input, out int number))
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Number is negative.");
                    }
                    else if (IsPrime(number))
                    {
                        primeSum += number;
                    }
                    else
                    {
                        nonPrimeSum += number;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integer or 'stop'.");
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }

        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else if (num <= 3)
            {
                return true;
            }
            else if (num % 2 == 0 || num % 3 == 0)
            {
                return false;
            }

            // Check for prime using a loop up to the square root of num
            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;



            //    int primeSum = 0;
            //    int nonPrimeSum = 0;

            //    while (true)
            //    {
            //        string input = Console.ReadLine();

            //        if (input.ToLower() == "stop")
            //        {
            //            break; // Exit the loop when "stop" is entered
            //        }

            //        if (int.TryParse(input, out int number))
            //        {
            //            if (number < 0)
            //            {
            //                Console.WriteLine("Number is negative.");
            //            }
            //            else if (IsPrime(number))
            //            {
            //                primeSum += number;
            //            }
            //            else
            //            {
            //                nonPrimeSum += number;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter an integer or 'stop'.");
            //        }
            //    }

            //    Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            //    Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
            //}

            //static bool IsPrime(int num)
            //{
            //    if (num <= 1)
            //    {
            //        return false;
            //    }

            //    for (int i = 2; i * i <= num; i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            return false;
            //        }
            //    }

            //    return true;
        }
    }
}