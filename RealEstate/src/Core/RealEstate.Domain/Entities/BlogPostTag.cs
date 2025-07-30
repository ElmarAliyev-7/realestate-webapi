using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class BlogPostTag : AuditableEntity
    {
        public int BlogPostId { get; set; }
        public int TagId { get; set; }
    }
}
