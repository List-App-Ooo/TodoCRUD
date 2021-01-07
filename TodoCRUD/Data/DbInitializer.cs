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

            var todos = new List<TodoModel>();
            Guid guid = new Guid("ef6a7925-80a6-44bc-9e03-89bc7ca3586f");

            todos.Add(
                new TodoModel() 
                {
                    Title = "Wash the car",
                    Desc = "Be sure to have the interior vacuumed and the exterior waxed.",
                    TimeStamp = DateTime.Now,
                    IsComplete = false,
                    ListId = guid
                }
            );
            todos.Add(
                new TodoModel() 
                {
                    Title = "Get groceries",
                    Desc = "Don't forget your fruits and veggies.",
                    TimeStamp = DateTime.Now,
                    IsComplete = false,
                    ListId = guid
                }
            );
            todos.Add(
                new TodoModel() 
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