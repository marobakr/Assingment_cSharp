namespace Assingment;


#region Part 01
public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string[] Authors { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }

    public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price) {
        ISBN = _ISBN;
        Title = _Title;
        Authors = _Authors;
        PublicationDate = _PublicationDate;
        Price = _Price;
    }

    public override string ToString()
    {
        return $"ISBN: {ISBN}\nTitle: {Title}\nAuthors: {string.Join(", ", Authors)}\nPublication Date: {PublicationDate.ToShortDateString()}\nPrice: {Price:C}";
    }
}

public static class BookFunctions
{
    public static string GetTitle(Book B)
    {
        return B.Title;
    }

    public static string GetAuthors(Book B)
    {
       return string.Join(", ", B.Authors);
    }

    public static string GetPrice(Book B)
    {
        return B.Price.ToString("C");
    }
}
#endregion

#region Part_1_2_A
// public static class LibraryEngine
// {
//     public static void ProcessBoks(List<Book> books ,CustomDelegate fPtr) 
//     {
//         foreach (Book book in books)
//         {
//             Console.WriteLine(fPtr(book));
//         }
//     }
// }
#endregion

#region Part1_2_B
public static class LibraryEngine
{
    public static void ProcessBoks(List<Book> books ,Func<Book,string> fPtr) 
    {
        foreach (Book book in books)
        {
            Console.WriteLine(fPtr(book));
        }
    }
}
#endregion


/* ====================== Part 02 ======================*/
    public class MyList<T> : List<T>
    {
        // Exists method
        public bool Exists(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));

            foreach (T item in this)
            {
                if (match(item))
                    return true;
            }

            return false;
        }

        // Find method
        public T Find(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));

            foreach (T item in this)
            {
                if (match(item))
                    return item;
            }

            return default;
        }

        // FindAll method
        public MyList<T> FindAll(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));

            MyList<T> result = new MyList<T>();
            foreach (T item in this)
            {
                if (match(item))
                    result.Add(item);
            }

            return result;
        }

        // FindIndex methods
        public int FindIndex(Predicate<T> match)
        {
            return FindIndex(0, this.Count, match);
        }

        public int FindIndex(int startIndex, Predicate<T> match)
        {
            return FindIndex(startIndex, this.Count - startIndex, match);
        }
    }

 
