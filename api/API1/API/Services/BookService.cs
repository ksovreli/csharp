using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class BookService(BookStoreContext context) : IBooksService
    {
        private readonly BookStoreContext _bookStoreContext = context;

        public async Task CreateAsync(Book book)
        {
            await _bookStoreContext.Books.AddAsync(book);
            await _bookStoreContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var findBook = await _bookStoreContext.Books.FindAsync(id);

            if (findBook != null)
            {
                _bookStoreContext.Books.Remove(findBook);
                await _bookStoreContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            var getBooks = await _bookStoreContext.Books.ToListAsync();
            return getBooks;
        }

        public async Task<Book?> GetBooksByIdAsync(int id)
        {
            var getBooksById = await _bookStoreContext.Books.FindAsync(id);
            return getBooksById;
        }

        public async Task UpdateAsync(int id, Book newBook)
        {
            if (id != newBook.Id)
            {
                throw new InvalidOperationException("Book ID isnt valid.");
            }

            _bookStoreContext.Entry(newBook).State = EntityState.Modified;
            await _bookStoreContext.SaveChangesAsync();
        }
    }
}
