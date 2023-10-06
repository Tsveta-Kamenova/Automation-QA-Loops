namespace _36.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());

            for (int i = countDays; i >= 1; i--)
            {
                Console.WriteLine($"{i} days before the exam");
            }
            Console.WriteLine($"The exam has come");
        }
    }
}