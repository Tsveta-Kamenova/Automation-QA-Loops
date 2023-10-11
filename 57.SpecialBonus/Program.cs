namespace _57.SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());
            int lastNumber = 1; ;

            while (true)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber != stopNumber)
                {
                    lastNumber = currentNumber;
                }
                else
                    break;
            }
            Console.WriteLine($"{lastNumber*1.2}");
        }
    }
}