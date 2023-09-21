namespace _12.Half_SumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int sumNumbers = 0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < numberOfLines; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumNumbers += currentNumber;

                if (maxNumber < currentNumber)
                {
                    maxNumber = currentNumber;
                }
            }
             
            int SumWithoutMaxNumber = sumNumbers - maxNumber;

            if (maxNumber == SumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNumber);
            }
            else
            {
                int diff = Math.Abs(maxNumber - SumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}