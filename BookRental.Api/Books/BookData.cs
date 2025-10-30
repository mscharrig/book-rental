namespace BookRental.Api.Books;

public static class BookData
{
    public static List<Book> Data => new()
    {
        new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin", IsRented = false },
        new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", IsRented = false },
        new Book { Id = 3, Title = "Refactoring", Author = "Martin Fowler", IsRented = false },
        new Book { Id = 4, Title = "Code Complete", Author = "Steve McConnell", IsRented = false },
        new Book { Id = 3, Title = "Domain-Driven Design: Tackling Complexity in the Heart of Software", Author = "Eric Evans", IsRented = false }
    };
}