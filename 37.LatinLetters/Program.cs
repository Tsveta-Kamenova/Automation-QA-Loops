﻿namespace _37.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter;  i <= secondLetter; i++)
            {
                Console.Write(i);
                if (i < secondLetter)
                    Console.Write(" ");
            }
        }
    }
}