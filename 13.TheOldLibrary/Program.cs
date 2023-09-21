namespace _13.TheOldLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookToSearch = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int counter = 0;

            bool bookIsFound = false;
           
            while (currentBook != "No More Books")
            { 
                if (currentBook != bookToSearch)
                {
                    counter += 1;
                    currentBook = Console.ReadLine();
                }
                else
                {
                    bookIsFound = true;
                    break;
                }
                
            }

            switch(bookIsFound)
            {
                case true: Console.WriteLine($"You checked {counter} books and found it."); break;
                case false:
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books."); break;
            }

            

        }
    }
}