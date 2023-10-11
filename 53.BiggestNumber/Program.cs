namespace _53.BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int max = int.MinValue;

            for (int i = 1; i <= countNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            Console.WriteLine($"{max}");
        }
    }
}