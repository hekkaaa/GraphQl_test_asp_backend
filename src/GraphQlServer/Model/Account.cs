namespace GraphQlServer.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public bool? IsBlock { get; set; }
    }
}
