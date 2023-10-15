namespace _72.MagicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int num = 100; num <= 999; num++)
            {
                int digit1 = num % 10;
                int digit2 = (num / 10) % 10;
                int digit3 = num / 100;

                if (digit1 * digit2 * digit3 == N)
                {
                    Console.Write(num+" ");
                }
            }
        }
    }
}