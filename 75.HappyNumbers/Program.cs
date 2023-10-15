using System;

namespace _75.HappyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine() ?? "2");

            for (int i = 1000; i < 9999; i++)
            {
                int digit1 = i % 10;
                int digit2 = (i / 10) % 10;
                int digit3 = (i / 100) % 10;
                int digit4 = i / 1000;

                int firstTwo = digit1 + digit2;
                int lastTwo = digit3 + digit4;

                if (firstTwo == lastTwo && firstTwo == number)
                {
                    Console.Write($"{digit4}{digit3}{digit2}{digit1} ");
                }
            }
        }
    }
}