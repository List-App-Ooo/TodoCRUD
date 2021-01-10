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

        [HttpGet("{id}")]
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
    }
}