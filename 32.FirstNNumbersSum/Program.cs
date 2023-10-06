namespace _32.FirstNNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            
            int sumNumbers = 0;

            for (int i = 1; i <= endNumber; i++)
            {
                Console.Write(i);
                if (i < endNumber)
                    Console.Write("+");
                sumNumbers += i;
            }
            Console.Write("="+sumNumbers);
        }
    }
}