using System;

namespace GraphQlServer.Repository.Entities
{
    public class Movie : BaseEntity
    {
        public string? Title { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? BondId { get; set; }
        public Bond? Bond { get; set; }
        public Director? Director { get; set; }
    }
}
