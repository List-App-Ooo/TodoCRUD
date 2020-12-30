namespace TodoCRUD.Models
{
    public class TodoListModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int TotalItems { get; set; }
        public List<TodoItemModel> Items { get; set; }
    }
}