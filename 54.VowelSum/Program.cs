namespace _54.VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countValues = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < countValues; i++)
            {
                char vowel = char.Parse(Console.ReadLine());

                switch (vowel)
                {
                    case 'a': result += 1; break;
                    case 'e': result += 2; break;
                    case 'i': result += 3; break;
                    case 'o': result += 4; break;
                    case 'u': result += 5; break;
                }
            }
            Console.WriteLine(result);
        }
    }
}