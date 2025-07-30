using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class Partner : BaseEntity<int>
    {
        public string Name { get; set; }
        public string LogoPath { get; set; }
    }
}
