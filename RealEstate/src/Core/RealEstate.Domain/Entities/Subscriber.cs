namespace RealEstate.Domain.Entities
{
    public class Subscriber
    {
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Approved { get; set; }
        public DateTime ApprovedAt { get; set; }
    }
}
