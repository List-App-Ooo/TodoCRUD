using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoCRUD.Models;

namespace TodoCRUD.Data
{
    public interface ITodoRepo
    {
        Task<TodoModel> GetTodoItem(Guid id);
        Task<List<TodoModel>> GetTodoItems(Guid listId);
        Task<int> GetTotal(Guid postId);
    }
}