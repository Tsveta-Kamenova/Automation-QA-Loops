namespace _14.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoorGradesAllowed = int.Parse(Console.ReadLine());

            int counterPoorGrades = 0;
            int counterProblems = 0;
            double sumGrades = 0.0;
            bool isFailed = true;
            string lastProblem = "";

            while (counterPoorGrades < numberOfPoorGradesAllowed)
            {
                string currentProblem = Console.ReadLine();

                if (currentProblem == "Enough")
                {
                    isFailed = false;
                    break;
                }

                int currentGrade = int.Parse(Console.ReadLine());

                if (currentGrade <= 4)
                {
                    counterPoorGrades += 1; 
                    
                }
                
                counterProblems ++;
                sumGrades += currentGrade;

                lastProblem = currentProblem;
            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {counterPoorGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sumGrades / counterProblems:F2}");
                Console.WriteLine($"Number of problems: {counterProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");

            }
        }
    }
}