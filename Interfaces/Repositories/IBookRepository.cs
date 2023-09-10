public interface IBookRepository
{
    public Task<IEnumerable<Book>> GetAllBooks();
    public Task<Book> GetBookById(Guid id);
    public Task<Book> AddBook(Book book);
    
}