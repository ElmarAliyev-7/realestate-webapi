using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class AnnouncementMedia : BaseEntity<int>
    {
        public int AnnouncementId { get; set; }
        public string Path { get; set; }
        public bool IsMain { get; set; }
        public int Type { get; set; }
    }
}
