using Library;

//Book book = new Book();
//// This information is for one book in our library.
//book.Title = "C# for beginners";
//book.Author = "BillGates";
//book.ISBN = "12345678";

//book.DisplayBookInfo();

////This is another book is our library
//Book book1 = new Book();
//book1.Title = "C# Methods and classes";
//book1.Author = "Microsoft";
//book1.ISBN = "55667778";

//book1.DisplayBookInfo();

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance (object) of the Book class
        // Note how the object name differs from the class name
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");

        book.DisplayInfo();
    }
}
