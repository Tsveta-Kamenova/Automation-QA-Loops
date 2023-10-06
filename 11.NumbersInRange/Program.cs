namespace _11.NumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            for (int i = numberOne; i <= numberTwo; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}