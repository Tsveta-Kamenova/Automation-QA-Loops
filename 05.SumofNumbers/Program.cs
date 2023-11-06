namespace _05.SumofNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine() ?? "1");

            double sumGrades = 0.0;

            for (int i = 0; i < countStudents; i++)
            {
                double currentGrade = double.Parse(Console.ReadLine() ?? "1");
                sumGrades += currentGrade;
            }
            double averageGrade = sumGrades / countStudents;
            Console.WriteLine($"{averageGrade:2F}");
        }
    }
}