namespace _25.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine() ?? "1");


            for (int i = 1111; i <= 9999; i++)
            {
                string currentString = i.ToString();
                bool isSpecial = true;

                for (int curNum = 0; curNum < currentString.Length; curNum++)
                {
                    int curNumValue = int.Parse(currentString[curNum].ToString());

                    if (curNumValue == 0 || number % curNumValue != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }
                if (isSpecial)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}