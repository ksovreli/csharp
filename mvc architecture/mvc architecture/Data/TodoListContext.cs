using Microsoft.EntityFrameworkCore;
using mvc_architecture.Models.Entities;

namespace mvc_architecture.Data
{
    public class TodoListContext : DbContext
    {
        public DbSet<TodoListItem> todoListItems { get; set; }

        public TodoListContext(DbContextOptions options): base(options)
        {
        }
    }
}
