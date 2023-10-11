namespace _56.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine() ?? "1");

            string currentString = number.ToString();
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
                Console.Write(number + " is special");
            else
                Console.Write(number + " is not special");
        }
    }
}