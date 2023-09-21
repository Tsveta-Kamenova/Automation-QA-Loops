namespace _17.Coins
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                decimal changeAmount = decimal.Parse(Console.ReadLine());
                int totalCoins = 0;

                // Convert changeAmount to stotinki (multiply by 100)
                int stotinkiAmount = (int)(changeAmount * 100);

                int numTwoLeva = stotinkiAmount / 200; // 2 leva coins
                stotinkiAmount %= 200;

                int numOneLeva = stotinkiAmount / 100; // 1 leva coins
                stotinkiAmount %= 100;

                int numFiftyStotinki = stotinkiAmount / 50; // 50 stotinki coins
                stotinkiAmount %= 50;

                int numTwentyStotinki = stotinkiAmount / 20; // 20 stotinki coins
                stotinkiAmount %= 20;

                int numTenStotinki = stotinkiAmount / 10; // 10 stotinki coins
                stotinkiAmount %= 10;

                int numFiveStotinki = stotinkiAmount / 5; // 5 stotinki coins
                stotinkiAmount %= 5;

                int numTwoStotinki = stotinkiAmount / 2; // 2 stotinki coins
                stotinkiAmount %= 2;

                int numOneStotinka = stotinkiAmount; // 1 stotinka coins

                totalCoins = numTwoLeva + numOneLeva + numFiftyStotinki + numTwentyStotinki + numTenStotinki + numFiveStotinki + numTwoStotinki + numOneStotinka;
                Console.WriteLine(totalCoins);
            }
        }
    }