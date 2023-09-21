namespace _11.NumbersUpTo1000Endingin7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentNumber = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}