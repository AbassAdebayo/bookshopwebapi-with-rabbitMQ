
using Microsoft.EntityFrameworkCore;

public class BookRepository : IBookRepository
{
    private readonly BookshopContext _bookshopContext;

    public BookRepository(BookshopContext bookshopContext)
    {
        _bookshopContext = bookshopContext;
    }

    public async Task<Book> AddBook(Book book)
    {
        await _bookshopContext.Books.AddAsync(book);
        await _bookshopContext.SaveChangesAsync();
        return book;
    }

    public async Task<IEnumerable<Book>> GetAllBooks()
    {
        return await _bookshopContext.Books.Select(b => new Book
        {
            CreatedAt = b.CreatedAt,
            Id = b.Id,
            Author = b.Author,
            Title = b.Title
        }).OrderBy(b => b.Title)
        .AsNoTracking()
        .ToListAsync();
    }

    public async Task<Book> GetBookById(Guid id)
    {
        return await _bookshopContext.Books.FirstOrDefaultAsync(b=> b.Id == id);
    }
}