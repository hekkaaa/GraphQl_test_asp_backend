using System.ComponentModel.DataAnnotations;

namespace GraphQlServer.Repository.Entities
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Type is required")]
        public TypeOfAccount Type { get; set; }
        public string Description { get; set; }
    }
}
