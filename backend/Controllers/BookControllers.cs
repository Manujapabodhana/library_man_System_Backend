using backend.Data;
using backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class BooksController : ControllerBase
{
    private readonly LibraryDbContext _context;

    public BooksController(LibraryDbContext context)
    {
        _context = context;
    }

    // GET: api/books
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
    {
        var books = await _context.Books.ToListAsync();
        return Ok(books);
    }

    // GET: api/books/5
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Book>> GetBook(int id)
    {
        var book = await _context.Books.FindAsync(id);

        if (book == null)
            return NotFound();

        return Ok(book);
    }

    // POST: api/books
    [HttpPost]
    public async Task<ActionResult<Book>> CreateBook(Book book)
    {
        //  Ensure SQLite/EF generates the Id (prevents UNIQUE constraint failed: Books.Id)
        book.Id = 0;

        // With [ApiController] + DataAnnotations, invalid models automatically return 400.
        _context.Books.Add(book);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
    }

    // PUT: api/books/5
    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateBook(int id, Book book)
    {
        if (id != book.Id)
            return BadRequest("Route id does not match body id.");

        var existing = await _context.Books.FindAsync(id);
        if (existing == null)
            return NotFound();

        //  Update fields explicitly (prevents overposting + avoids EF tracking issues)
        existing.Title = book.Title;
        existing.Author = book.Author;
        existing.Description = book.Description;
        existing.ISBN = book.ISBN;
        existing.PublishedDate = book.PublishedDate;
        existing.AvailableCopies = book.AvailableCopies;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE: api/books/5
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteBook(int id)
    {
        var book = await _context.Books.FindAsync(id);
        if (book == null)
            return NotFound();

        _context.Books.Remove(book);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
