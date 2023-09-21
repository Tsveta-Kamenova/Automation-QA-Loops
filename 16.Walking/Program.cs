namespace _16.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalSteps = 10000;
            int sumSteps = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    sumSteps += lastSteps;

                    if (sumSteps >= goalSteps)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{sumSteps - goalSteps} steps over the goal!");
                    }
                    else
                    {
                        Console.WriteLine($"{goalSteps - sumSteps} more steps to reach goal.");
                    }

                    break; // Exit the loop when going home
                }
                else if (int.TryParse(input, out int currentSteps))
                {
                    sumSteps += currentSteps;

                    if (sumSteps >= goalSteps)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{sumSteps - goalSteps} steps over the goal!");
                        break; // Exit the loop when the goal is reached
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number or 'Going home'.");
                }
            }
        }
    }
}