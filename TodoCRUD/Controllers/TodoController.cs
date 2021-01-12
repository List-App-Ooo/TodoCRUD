using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoCRUD.Models;
using TodoCRUD.Services;

namespace TodoCRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            this._todoService = todoService;
        }

        [HttpGet("{id}", Name="GetTodo")]
        public async Task<IActionResult> GetTodo(Guid id)
        {
            var result = await _todoService.GetTodo(id);
            return Ok(result);
        }
        [HttpGet("list/{listId}")]
        public async Task<IActionResult> GetTodos(Guid listId)
        {
            var result = await _todoService.GetTodos(listId);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTodo(TodoModel todo)
        {
            if (todo is null) return BadRequest();
            var result = await _todoService.CreateTodo(todo);
            return CreatedAtRoute(nameof(GetTodo), new { Id = result.Id }, result);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTodo(Guid id)
        {
            _todoService.DeleteTodo(id);
            return NoContent();
        }
    }
}