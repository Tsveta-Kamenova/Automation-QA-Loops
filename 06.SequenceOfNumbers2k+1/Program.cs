﻿namespace _06.SequenceOfNumbers2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());
            
            int currentNumber = 1;

            while (currentNumber <= lastNumber)
            {
                Console.WriteLine(currentNumber);
                currentNumber = currentNumber*2 + 1;
            }
            
        }
    }
}