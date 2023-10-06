namespace _46.NumberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialNumber = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "End") 
            {
                if (command == "Inc")
                    initialNumber ++;
                else if (command == "Dec")
                    initialNumber --;
                command = Console.ReadLine();
            }
            Console.WriteLine(initialNumber);
        }
    }
}