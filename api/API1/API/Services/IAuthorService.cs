using API.Models;

namespace API.Services
{
    public interface IAuthorService
    {
        Task CreateAsync(Author author);
        Task<IEnumerable<Author>> GetAuthorsAsync();
        Task<Author?> GetAuthorByIdAsync(int id);
        Task UpdateAsync(int id, Author newAuthor);
        Task DeleteByIdAsync(int id);
    }
}
