namespace RealEstate.Domain.Commons
{
    public class BaseEntity<T> : AuditableEntity
        where T : unmanaged
    {
        public T Id { get; set; }
    }
}
