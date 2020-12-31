using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoCRUD.Models;

namespace TodoCRUD.Services
{
    public interface ITodoService
    {
        public Task<List<TodoItemModel>> GetTodos(Guid listId);
        public Task<int> GetTodoTotal(Guid listId);
    }
}