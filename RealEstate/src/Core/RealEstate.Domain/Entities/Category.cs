using RealEstate.Domain.Commons;

namespace RealEstate.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }
}
