using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TodoCRUD.Data;
using TodoCRUD.Models;

namespace TodoCRUD.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepo _todoRepo;

        public TodoService(ITodoRepo todoRepo)
        {
            this._todoRepo = todoRepo;
        }

        public async Task<List<TodoItemModel>> GetTodos(Guid listId)
        {
            return await _todoRepo.GetTodoItems(listId);
            
            // throw new NotImplementedException();
        }

        public async Task<int> GetTodoTotal(Guid listId)
        {
            return await _todoRepo.GetTotal(listId);
        }
    }
}