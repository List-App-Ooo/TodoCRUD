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
        public async Task<List<TodoModel>> GetTodoItems(Guid listId)
        {
            var query = _context.Todos.Where(m => m.ListId == listId).OrderBy(d => d.TimeStamp);
            return await query.ToListAsync<TodoModel>();
        }

        public async Task<int> GetTotal(Guid listId)
        {
            return await _context.Todos.CountAsync(m => m.ListId == listId);
        }
    }
}