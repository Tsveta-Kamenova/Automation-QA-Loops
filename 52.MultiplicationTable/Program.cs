namespace _52.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToMultiply = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numberToMultiply} * {i} = {numberToMultiply * i}");
            }
        }
    }
}