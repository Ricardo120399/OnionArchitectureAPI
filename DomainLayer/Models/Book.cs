
namespace DomainLayer.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public Author Author { get; set; }
        public int AuthorId { get; set; }
        //public ICollection<Author> Authors { get; set; }
    }
}
