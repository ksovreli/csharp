using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_architecture.Data;

namespace mvc_architecture.Controllers
{
    public class TodoListController : Controller
    {
        private readonly TodoListContext _context;
        public TodoListController(TodoListContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Models.Entities.TodoListItem> lists = await _context.todoListItems.ToListAsync();
            return View(lists);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
