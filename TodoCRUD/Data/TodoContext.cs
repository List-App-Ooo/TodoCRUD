using Microsoft.EntityFrameworkCore;
using TodoCRUD.Models;

namespace TodoCRUD.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) {}

        public DbSet<TodoItemModel> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}