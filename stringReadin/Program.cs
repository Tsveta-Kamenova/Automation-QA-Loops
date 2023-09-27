namespace stringReadin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textToRead = Console.ReadLine();

            for (int i = 0; i <= textToRead.Length - 1; i ++)
            {
                Console.WriteLine(textToRead[i]);
            }
        }
    }
}