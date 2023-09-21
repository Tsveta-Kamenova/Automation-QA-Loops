namespace _10.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int counter = 0;
            int counterFail = 0;
            double sumGrades = 0.0;
            bool expelled = false;


            for (int i = 0; i <= 11; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4.00)
                {
                    counterFail += 1;
                    if (counterFail > 1)
                    {
                        expelled = true;
                        break;
                    }
                }
                else
                {
                    sumGrades += grade;
                }

                counter += 1;
            }


            if (expelled == true)
            {
                Console.WriteLine($"{studentName} has been excluded at {counter} grade");
            }
            else
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {(sumGrades / counter):F2}");
            }

        }
    }
}