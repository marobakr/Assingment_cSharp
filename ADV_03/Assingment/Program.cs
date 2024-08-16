namespace Assingment;

/* ====================== Part 01 ======================*/

// public delegate string CustomDelegate (Book book);

class Program
{
    static void Main(string[] args)
    {
        
        string[] authors = new string[] { "Author1", "Author2", "Author3" };
        Book myBook0 = new Book( "978-3-16-148410-0", "Learning C#", authors, new DateTime(2022, 5, 1), 29.99m  ); 
        Book myBook1 = new Book( "978-3-16-148410-0", "Learning C#", authors, new DateTime(2022, 5, 1), 29.99m  ); 
        Book myBook2 = new Book( "978-3-16-148410-0", "Learning C#", authors, new DateTime(2022, 5, 1), 29.99m  ); 
             
        List<Book> books = new List<Book>() {myBook0, myBook1, myBook2 };
        
        #region Implement Part_1_2_A
        // CustomDelegate customDelegate = BookFunctions.GetAuthors;
        // LibraryEngine.ProcessBoks(books,customDelegate);
        // LibraryEngine.ProcessBoks(books,BookFunctions.GetAuthors);
        // LibraryEngine.ProcessBoks(books,BookFunctions.GetAuthors);
        #endregion
    
        #region Implement Part_1_2_B
        // Func<Book,string> func = BookFunctions.GetAuthors;
        // LibraryEngine.ProcessBoks(books,func);
        // LibraryEngine.ProcessBoks(books,BookFunctions.GetTitle);
        // LibraryEngine.ProcessBoks(books,BookFunctions.GetPrice);
        #endregion

        #region Implement Part_1_2_C
        // Func<Book, string> func = delegate(Book book) { return book.ISBN;};
        // string  ISbn = func(myBook0);
        // Console.WriteLine(ISbn);
        #endregion
        
        #region Implement Part_1_2_D
        // Func<Book, string> func = book =>  book.ISBN;
        // string  ISbn = func(myBook0);
        // Console.WriteLine(ISbn);
        #endregion
    }
}