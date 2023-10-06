namespace _51.PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numberToPower = float.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= numberToPower;
            }
            Console.WriteLine(result);
        }
    }
}