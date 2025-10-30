namespace BookRental.Api.Books;

public interface IBookStore
{
    List<Book> GetAllBooks();
}

public class BookStore : IBookStore
{
    private readonly List<Book> _books;
    private readonly List<Rental> _rentals;

    public BookStore()
    {
        _books = BookData.Data;
        _rentals = new List<Rental>();
    }
    
    public List<Book> GetAllBooks() => _books;
}

public class Book
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public required string Author { get; set; }
    public required bool IsRented { get; set; }
}

public class Rental
{
    public required int UserId { get; set; }
    public required int BookId { get; set; }
    public required DateTimeOffset RentedAt { get; set; }
    public required string RentedBy { get; set; }
}