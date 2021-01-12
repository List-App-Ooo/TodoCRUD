using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoCRUD.Models;

namespace TodoCRUD.Data
{
    public interface ITodoRepo
    {
        Task<TodoModel> GetTodo(Guid id);
        Task<List<TodoModel>> GetTodos(Guid listId);
        Task<int> GetTotal(Guid postId);
        Task<TodoModel> CreateTodo(TodoModel todo);
        void DeleteTodo(Guid id);
        void DeleteTodos(Guid listId);
    }
}