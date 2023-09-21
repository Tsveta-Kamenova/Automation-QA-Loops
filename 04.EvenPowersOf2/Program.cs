namespace _04.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int num = 1;

            for (int i = 0; i <= inputNumber; i += 2)
            {
                    Console.WriteLine(num);
                    num = num * 2 * 2;
            }

            //for (int i = 0; i <= inputNumber; i += 1)
            //{
            //    if (i % 2 == 0)
            //    {
            //        output = Math.Pow(2, i);
            //        Console.WriteLine(output);
            //    }
            //}
        }
    }
}