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
        public async Task<TodoModel> GetTodo(Guid id)
        {
            return await _todoRepo.GetTodo(id);
        }
        public async Task<List<TodoModel>> GetTodos(Guid listId)
        {
            return await _todoRepo.GetTodos(listId);
        }
        public async Task<int> GetTotal(Guid listId)
        {
            return await _todoRepo.GetTotal(listId);
        }
        public async Task<TodoModel> CreateTodo(TodoModel todo)
        {
            var newTodo = new TodoModel {
                Id = Guid.NewGuid(),
                Title = todo.Title,
                Desc = todo.Desc,
                IsComplete = todo.IsComplete,
                TimeStamp = DateTime.Now,
                ListId = todo.ListId
            };

            return await _todoRepo.CreateTodo(newTodo);
        }
        public void DeleteTodo(Guid id)
        {
            _todoRepo.DeleteTodo(id);
        }
    }
}