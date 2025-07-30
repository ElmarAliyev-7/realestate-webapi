using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class BlogPostComment : BaseEntity<int>
    {
        public int BlogPostId { get; set; }
        public int? ParentId { get; set; }
        public string Text { get; set; }
    }
}
