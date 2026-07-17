namespace Assigment9_library.Data;

public class BookData
{
    public Stack<string> BookList()
    {
        var books = new Stack<string>();

        books.Push("C#");
        books.Push("SQL");
        books.Push("Java");
        books.Push("Python");

        return books;
    }
}