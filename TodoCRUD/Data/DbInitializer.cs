using System;
using System.Collections.Generic;
using System.Linq;
using TodoCRUD.Models;

namespace TodoCRUD.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            if (context.Todos.Any())
            {
                return;
            }

            var todos = new List<TodoItemModel>();
            Guid guid = new Guid();

            todos.Add(
                new TodoItemModel() 
                {
                    Title = "Wash the car",
                    Desc = "Be sure to have the interior vacuumed and the exterior waxed.",
                    TimeStamp = DateTime.Now,
                    IsComplete = false,
                    ListId = guid
                }
            );
            todos.Add(
                new TodoItemModel() 
                {
                    Title = "Get groceries",
                    Desc = "Don't forget your fruits and veggies.",
                    TimeStamp = DateTime.Now,
                    IsComplete = false,
                    ListId = guid
                }
            );
            todos.Add(
                new TodoItemModel() 
                {
                    Title = "Take out the trash",
                    Desc = "Get the trash out of the guest bathroom too.",
                    TimeStamp = DateTime.Now,
                    IsComplete = false,
                    ListId = guid
                }
            );

            context.Todos.AddRange(todos);
            context.SaveChanges();
        }
    }
}