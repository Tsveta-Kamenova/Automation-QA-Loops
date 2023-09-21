namespace _19.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int totalVolume = width * length * height;
            string input = Console.ReadLine();
            int neededVolume = 0;

            while (input != "Done")
            {
                int boxes = int.Parse(input);
                neededVolume += boxes;

                if (neededVolume > totalVolume)
                {
                    Console.WriteLine($"No more free space! You need {neededVolume - totalVolume} Cubic meters more.");
                    return; // Stop the program
                }

                input = Console.ReadLine();
            }

            int remainingVolume = totalVolume - neededVolume;
            Console.WriteLine($"{remainingVolume} Cubic meters left.");
        }
    }
}