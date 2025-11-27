namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.books();
        }
        
        static void countries()
        {
            
        }

        static void books()
        {
            Book myfirstBook = new Book();
            Book mysecondBook = new Book();

            Author myfavoriteAuthor = new Author() {Name = "Fjodor Dostoyevski", Nationality = "Russian", DateOfBirth = new DateTime(1890, 12, 13)};

            myfirstBook.Title = "Brothers Karamazov";
            myfirstBook.Author = myfavoriteAuthor;
            myfirstBook.Pages = 1000;
            myfirstBook.ISBN = "1234";

            mysecondBook.Title = "Crime and Punishment";
            mysecondBook.Author = myfavoriteAuthor;
            mysecondBook.Pages = 600;
            mysecondBook.ISBN = "2345";

            List<Book> books = new List<Book>();
            books.Add(myfirstBook);
            books.Add(mysecondBook);            

            Console.WriteLine("---------------");
            Console.WriteLine("My Books: \n");
            Console.WriteLine("---------------");
            foreach(Book book in books)
            {
                Console.WriteLine(
                    "Name: " + book.Title +
                    ", Author: " + book.Author + " ( " + book.Author.Nationality + ", " + book.Author.DateOfBirth.ToString("dd.MM.yyyy") + " )\n");
            }
        }
    }
}