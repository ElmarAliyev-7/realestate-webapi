namespace RealEstate.Infrastructure.Commons
{
    public interface IAuditableEntity
    {
        DateTime CreatedAt { get; set; }
        int? CreatedBy { get; set; }
        DateTime? LastModifiedAt { get; set; }
        int? LastModifiedBy { get; set; }
        DateTime? DeletedAt { get; set; }
        int? DeletedBy { get; set; }
    }
}
