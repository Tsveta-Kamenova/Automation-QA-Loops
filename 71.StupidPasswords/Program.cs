namespace _71.StupidPasswords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPass = int.Parse(Console.ReadLine() ?? "1");
            bool isEven = false;
            int productEnd = 0;

            if (numberPass % 2 == 0)
                isEven = true;

            if (isEven)
                productEnd = numberPass / 2;
            else
                productEnd = numberPass / 2 + 1;
            
            for (int i = 2; i <= numberPass; i += 2)
            {
                for (int j = 1; j <= numberPass; j += 2)
                {
                    Console.Write($"{i}{j}");

                    for (int k = 1; k < productEnd; k += 1)
                    {
                        Console.Write(i * j);
                        Console.Write(" ");
                        break;
                    }
                }
            }



        }
    }
}