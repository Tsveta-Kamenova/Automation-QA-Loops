namespace _74.LetterCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine() ?? "a");
            char endLetter = char.Parse(Console.ReadLine() ?? "a");
            char excludedLetter = char.Parse(Console.ReadLine() ?? "a");

            int countCombinations = 0;

            for (char firstLetter = startLetter; firstLetter <= endLetter; firstLetter++)
            {
                for (char secondLetter = startLetter; secondLetter <= endLetter; secondLetter++)
                {
                    for (char thirdLetter = startLetter; thirdLetter <= endLetter; thirdLetter++)
                    {
                        if (firstLetter != excludedLetter && secondLetter != excludedLetter && thirdLetter != excludedLetter)
                        {
                            Console.Write($"{firstLetter}{secondLetter}{thirdLetter} ");
                            countCombinations ++;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(countCombinations);
        }
    }
}