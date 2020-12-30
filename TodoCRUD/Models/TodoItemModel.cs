namespace TodoCRUD.Models
{
    public class TodoItemModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool isComplete { get; set; }
        public Guid TodoListId { get; set; }
    }
}