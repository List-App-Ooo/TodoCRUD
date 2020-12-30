using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoCRUD.Models;

namespace TodoCRUD.Data
{
    public interface ITodoRepo
    {
        Task<List<TodoItemModel>> GetTodoItems(Guid listId);
        Task<int> GetTotal(Guid postId);
    }
}