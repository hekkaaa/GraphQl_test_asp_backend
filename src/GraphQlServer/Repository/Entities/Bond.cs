namespace GraphQlServer.Repository.Entities
{
    public class Bond : BaseEntity
    {
        public string? Name { get; set; }
        public List<Movie>? Movies { get; set; }
    }
}
