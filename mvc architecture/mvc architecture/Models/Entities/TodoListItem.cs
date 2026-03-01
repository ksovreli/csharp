namespace mvc_architecture.Models.Entities
{
    public class TodoListItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
