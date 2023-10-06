namespace _45.NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 1 && number <= 100)
                {
                    Console.WriteLine(number);
                    break;
                }
  
            }            
        }
    }
}