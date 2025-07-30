using RealEstate.Infrastructure.Commons;

namespace RealEstate.Domain.Commons
{
    public class AuditableEntity : IAuditableEntity
    {
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
