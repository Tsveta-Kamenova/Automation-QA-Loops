namespace _68.PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine() ?? "1");
            int secondNumber = int.Parse(Console.ReadLine() ?? "1");

            bool isPrime = false;

            for (int currentNumber = firstNumber; currentNumber < secondNumber; currentNumber ++)
            {

                if (currentNumber != 0 || currentNumber != 1)
                {
                    for (int a = 2; a <= currentNumber / 2; a++)
                    {
                        if (currentNumber % a != 0)
                        {
                            isPrime = true;
                            continue;
                        }
                        else
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                    Console.Write(currentNumber + " ");
            }
        }
    }
}


//        static bool IsPrime(int number)
//        {
//            if (number <= 1) return false;
//            if (number <= 3) return true;
//            if (number % 2 == 0 || number % 3 == 0) return false;

//            for (int i = 5; i * i <= number; i += 6)
//            {
//                if (number % i == 0 || number % (i + 2) == 0)
//                    return false;
//            }

//            return true;
//        }

//        static void Main(string[] args)
//        {
//            int firstNumber = int.Parse(Console.ReadLine() ?? "1");
//            int secondNumber = int.Parse(Console.ReadLine() ?? "1");

//            for (int currentNumber = Math.Max(2, firstNumber); currentNumber <= secondNumber; currentNumber++)
//            {
//                if (IsPrime(currentNumber))
//                {
//                    Console.Write(currentNumber + " ");
//                }
//            }
//        }
