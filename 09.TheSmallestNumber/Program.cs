namespace _09.TheSmallestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentInput = Console.ReadLine();
            int min = int.MaxValue;

            while (currentInput != "Stop")
            {
                int num = int.Parse(currentInput);

                if (num < min)
                {
                    min = num;
                }


                currentInput = Console.ReadLine();
            }

            Console.WriteLine($"{min}");
        }
    }
}