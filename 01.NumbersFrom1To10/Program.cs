﻿namespace _01.NumbersFrom1To10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}