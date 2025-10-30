using Microsoft.AspNetCore.Mvc;

namespace BookRental.Api.Books;

[ApiController]
[Route("api/books")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public IActionResult GetBooks()
    {
        var books = _bookService.GetAllBooks();
        return Ok(books);
    }

    // TODO: implemented rent book
    
    // TODO: implemented return book
}