namespace GraphQlServer.Model
{
    public class TaskList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<SubTask> Tasks { get; set; }
        public bool IsDelete { get; set; }
    }
}
