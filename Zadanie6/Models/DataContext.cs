using Microsoft.EntityFrameworkCore;
using TodoApi.Models;


namespace Zadanie6.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<TodoApi.Models.TodoItem> TodoItem { get; set; }
    }
}
