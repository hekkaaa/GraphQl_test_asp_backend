namespace GraphQlServer.Model
{
    public class SubTask
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsCompleted { get; set; }
        public bool? IsDelete { get; set; }
    }
}
