namespace _73.UniquePINCodes
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int max1 = int.Parse(Console.ReadLine() ?? "1");
            int max2 = int.Parse(Console.ReadLine() ?? "1");
            int max3 = int.Parse(Console.ReadLine() ?? "1");

            for (int i = 2; i <= max1; i += 2)
            {
                for (int j = 1; j <= max2; j++)
                {
                    if (IsPrime(j) && j <= 7 && j >= 2)    

                        for (int k = 2; k <= max3; k += 2)
                        {
                            Console.Write($"{i}{j}");
                            Console.Write($"{k}");
                            Console.WriteLine();
                        }
                }
            }

        }
    }
}