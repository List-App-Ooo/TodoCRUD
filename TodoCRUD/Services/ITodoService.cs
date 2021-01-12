using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoCRUD.Models;

namespace TodoCRUD.Services
{
    public interface ITodoService
    {
        Task<TodoModel> GetTodo(Guid id);
        Task<List<TodoModel>> GetTodos(Guid listId);
        Task<int> GetTodoTotal(Guid listId);
        Task<TodoModel> CreateTodo(TodoModel todo);
        void DeleteTodo(Guid id);
    }
}