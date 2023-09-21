namespace _18._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int widthCake = int.Parse(Console.ReadLine());
            int lengthCake = int.Parse(Console.ReadLine());
            int cakePieces = widthCake * lengthCake;

            int sumTakenPieces = 0;


            while (true)
            {
                string firstInput = Console.ReadLine();

                if (firstInput == "STOP")
                {
                    if (sumTakenPieces < cakePieces)
                    {
                        Console.WriteLine($"{cakePieces - sumTakenPieces} pieces are left.");
                        break;
                    }
                }
                else
                {
                    int takenPieces = int.Parse(firstInput);
                    sumTakenPieces += takenPieces;

                    if (sumTakenPieces > cakePieces)
                    {
                        Console.WriteLine($"No more cake left! You need {sumTakenPieces - cakePieces} pieces more.");
                        break;
                    }
                }
            }   
        }
    }
}