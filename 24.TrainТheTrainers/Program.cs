using System;

namespace TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberGrades = int.Parse(Console.ReadLine());

            string firstInput;
            double averageGradeAllPresentations = 0.0;
            int counterAllPresentations = 0;
            string presentationDetails = "";

            while (true)
            {
                firstInput = Console.ReadLine();

                if (firstInput == "Finish")
                {
                    break;
                }

                string currentPresentation = firstInput;

                int counterCurrentPresentation = 0;
                double sumCurrentPresentation = 0.0;

                for (int i = 1; i <= numberGrades; i++)
                {
                    double currentPresentationGrade = double.Parse(Console.ReadLine());

                    sumCurrentPresentation += currentPresentationGrade;
                    counterCurrentPresentation++;
                }

                double averageGradeCurrentPresentation = sumCurrentPresentation / counterCurrentPresentation;

                presentationDetails += $"{currentPresentation} - {averageGradeCurrentPresentation:F2}.\n";

                counterAllPresentations++;
                averageGradeAllPresentations += averageGradeCurrentPresentation;
            }

            if (counterAllPresentations > 0)
            {
                averageGradeAllPresentations /= counterAllPresentations;
                Console.WriteLine(presentationDetails + $"Student's final assessment is {averageGradeAllPresentations:F2}.");
            }
        }
    }
}
