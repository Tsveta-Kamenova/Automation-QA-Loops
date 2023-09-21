namespace _08.TheGreatestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentInput = Console.ReadLine();
            int max = int.MinValue;

            while (currentInput != "Stop")
            {
                int num = int.Parse(currentInput);

                if (num > max)
                {
                    max = num;
                }


                currentInput = Console.ReadLine();
            }

            Console.WriteLine($"{max}");
        }
    }
}