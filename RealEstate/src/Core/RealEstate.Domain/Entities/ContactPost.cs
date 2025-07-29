using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Entities
{
    public class ContactPost
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Answer { get; set; }
        public DateTime? AnsweredAt { get; set; }
        public int? AnsweredBy { get; set; }
        public DateTime CreartedAt { get; set; }
        public int? CreartedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
