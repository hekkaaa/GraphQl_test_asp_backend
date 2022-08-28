namespace GraphQlServer.Repository.Entities
{
    public class Director : BaseEntity
    {
        public string? Name { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
