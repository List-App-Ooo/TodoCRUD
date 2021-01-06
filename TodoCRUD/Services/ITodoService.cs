using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoCRUD.Models;

namespace TodoCRUD.Services
{
    public interface ITodoService
    {
        Task<List<TodoModel>> GetTodos(Guid listId);
        Task<int> GetTodoTotal(Guid listId);
    }
}