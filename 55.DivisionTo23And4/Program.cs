namespace _55.DivisionTo23And4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countValues = int.Parse(Console.ReadLine());

            double divisibleByTwo = 0.0;
            double divisibleByThree = 0.0;
            double divisibleByFour = 0.0;

            for (int i = 0; i < countValues; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                    divisibleByTwo ++;
                if (number % 3 == 0)
                    divisibleByThree ++;
                if (number % 4 == 0)
                    divisibleByFour ++;
            }
            
            Console.WriteLine($"{(divisibleByTwo / countValues) *100:F2}%");
            Console.WriteLine($"{(divisibleByThree / countValues) * 100:F2}%");
            Console.WriteLine($"{(divisibleByFour / countValues) * 100:F2}%");
        }
    }
}