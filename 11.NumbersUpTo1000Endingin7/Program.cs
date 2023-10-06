namespace _11.NumbersUpTo1000Endingin7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentNumber = 0;
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 6; i <= endNumber; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}