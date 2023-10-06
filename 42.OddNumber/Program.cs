namespace _42.OddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = 0;

            while (true)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                    continue;
                else
                    lastNumber = currentNumber;
                    break;
            }

            Console.WriteLine(lastNumber);
        }
    }
}