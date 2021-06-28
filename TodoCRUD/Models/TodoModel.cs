using System;

namespace TodoCRUD.Models
{
    public class TodoModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsComplete { get; set; }
        public Guid ListId { get; set; }
    }
}