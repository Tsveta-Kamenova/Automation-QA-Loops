namespace _41.DecreasingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int i = number;

            while (i > 0)
            {
                Console.WriteLine(i.ToString());
                i--;
            }
        }
    }
}