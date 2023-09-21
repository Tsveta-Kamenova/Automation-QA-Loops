namespace _22.EqualSumOfEvenAndOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallerNumber = int.Parse(Console.ReadLine());
            int biggerNumber = int.Parse(Console.ReadLine());

            for (int i = smallerNumber; i <= biggerNumber; i++)
            {
                string currentNumber = i.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < currentNumber.Length; j ++ )
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }
                if (oddSum == evenSum) 
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}