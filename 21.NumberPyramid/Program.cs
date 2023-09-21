namespace _21.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (currentNumber > n)
                    {
                        break;
                    }

                    Console.Write(currentNumber);
                    currentNumber++;

                    if (col < row && currentNumber <= n)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}