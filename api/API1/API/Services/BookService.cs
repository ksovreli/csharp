using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class BookService : IBooksService
    {
        private readonly BookStoreContext _bookContext;

        public BookService(BookStoreContext context)
        {
            _bookContext = context;
        }

        public async Task CreateAsync(Book book)
        {
            await _bookContext.Books.AddAsync(book);
            await _bookContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
            var findBook = await _bookContext.Books.FindAsync(id);

            if (findBook != null)
            {
                _bookContext.Books.Remove(findBook);
                await _bookContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            var getBooks = await _bookContext.Books.ToListAsync();
            return getBooks;
        }

        public async Task<Book?> GetBooksByIdAsync(int id)
        {
            var getBooksById = await _bookContext.Books.FindAsync(id);
            return getBooksById;
        }

        public async Task UpdateAsync(int id, Book newBook)
        {
            if (id != newBook.Id)
            {
                throw new InvalidOperationException("Book ID isnt valid.");
            }

            _bookContext.Entry(newBook).State = EntityState.Modified;
            await _bookContext.SaveChangesAsync();
        }
    }
}
