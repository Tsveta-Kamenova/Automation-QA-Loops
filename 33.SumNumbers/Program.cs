namespace _33.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double countNumbers = double.Parse(Console.ReadLine());

            double sumNumbers = 0.0;

            for (int i = 0; i < countNumbers; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                sumNumbers += currentNumber;
            }
            Console.WriteLine(sumNumbers);
        }
    }
}