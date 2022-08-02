
namespace DomainLayer.Models
{
    public class Author : BaseEntity
    {
        public string? Name {get;set;}
        public string? Address {get;set;}
        public string? Email {get;set;}
        public string? City { get;set;}
        public string? Country { get; set; }
        public int? Age { get; set; }
        public DateTime? BirthDate { get; set; }

        public List<Book>? Books { get; set; }
    }
}
