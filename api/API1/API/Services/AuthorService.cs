using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class AuthorService(BookStoreContext context) : IAuthorService
    {
        private readonly BookStoreContext _authorContext = context;

        public async Task CreateAsync(Author author)
        {
            await _authorContext.Authors.AddAsync(author);
            await _authorContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var findAuthor =  await _authorContext.Authors.FindAsync(id);
            if (findAuthor != null)
            {
                _authorContext.Authors.Remove(findAuthor);
                await _authorContext.SaveChangesAsync();
            }
        }

        public async Task<Author?> GetAuthorByIdAsync(int id)
        {
            var findAuthorById = await _authorContext.Authors.FindAsync(id);
            return findAuthorById;
        }

        public async Task<IEnumerable<Author>> GetAuthorsAsync()
        {
            var getAuthor = await _authorContext.Authors.ToListAsync();
            return getAuthor;
        }

        public async Task UpdateAsync(int id, Author newAuthor)
        {
            if (id != newAuthor.Id)
            {
                throw new InvalidOperationException("Author ID isn't valid.");
            }

            _authorContext.Entry(newAuthor).State = EntityState.Modified;
            await _authorContext.SaveChangesAsync();
        }
    }
}
