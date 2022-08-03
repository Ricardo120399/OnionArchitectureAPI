
namespace DomainLayer.Models
{
    public class Author : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public List<Book> Books { get; set; } = new();
    }
}
