
namespace DomainLayer.Dto
{
    public class AuthorDto : BaseEntityDto
    {
        public string NameDto { get; set; } = string.Empty;
        public string LastNameDto { get; set; } = string.Empty;
        public int AgeDto { get; set; }
    }
}
