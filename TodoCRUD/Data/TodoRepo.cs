using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using TodoCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoCRUD.Data
{
    public class TodoRepo : ITodoRepo
    {
        private TodoContext _context;

        public TodoRepo(TodoContext context)
        {
            this._context = context;
        }

        public async Task<TodoModel> GetTodo(Guid id)
        {
            var query = _context.Todos.FirstOrDefaultAsync(m => m.Id.Equals(id));
            return await query;
        }
        public async Task<List<TodoModel>> GetTodos(Guid listId)
        {
            var query = _context.Todos.Where(m => m.ListId.Equals(listId)).OrderBy(d => d.TimeStamp);
            return await query.ToListAsync<TodoModel>();
        }
        public async Task<int> GetTotal(Guid listId)
        {
            return await _context.Todos.CountAsync(m => m.ListId.Equals(listId));
        }
        public async Task<TodoModel> CreateTodo(TodoModel todo)
        {
            if (todo == null)
            {
                throw new ArgumentNullException(nameof(todo));
            }
            
            await _context.AddAsync(todo);
            await _context.SaveChangesAsync();
            return todo;
        }
        public async void DeleteTodo(Guid id)
        {
            var query = await _context.Todos.FirstOrDefaultAsync(m => m.Id.Equals(id));
            _context.Todos.Remove(query);
            await _context.SaveChangesAsync();
        }
        public void DeleteTodos(Guid listId)
        {
            throw new NotImplementedException();
        }
    }
}