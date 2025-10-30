namespace BookRental.Api.Books;

public interface IBookService
{
    List<Book> GetAllBooks();
}

public class BookService : IBookService
{
    private readonly IBookStore _bookStore;

    public BookService(IBookStore bookStore)
    {
        _bookStore = bookStore;
    }

    public List<Book> GetAllBooks() => _bookStore.GetAllBooks();
}