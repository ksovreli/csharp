using API.Models;

namespace API.Services
{
    public interface IBooksService
    {
        Task CreateAsync(Book book);
        Task<IEnumerable<Book>> GetBooksAsync();
        Task<Book?> GetBooksByIdAsync(int id);
        Task UpdateAsync(int id, Book newBook);
        Task DeleteByIdAsync(int id);
    }
}
