using API.Data;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookStoreController(IBooksService bookService, IAuthorService authorService) : ControllerBase
    {
        private readonly IBooksService _bookService = bookService;
        private readonly IAuthorService _authorService = authorService;

        [HttpGet("GetBooks")]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookService.GetBooksAsync();
        }

        [HttpGet("GetBooksById/{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            Book? findBookById = await _bookService.GetBooksByIdAsync(id);
            if (findBookById == null)
            {
                return NotFound();
            }
            return Ok(findBookById);
        }

        [HttpGet("GetAuthors")]
        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await _authorService.GetAuthorsAsync();
        }
    }
}
