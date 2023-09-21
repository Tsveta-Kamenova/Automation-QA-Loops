namespace _03.NumbersFrom1ToNStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i+=3)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}