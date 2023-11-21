using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("familymember", Schema = "loyalty")]
    public class FamilyMember : EntityBase
    {
        public FamilyMember() : base()
        { }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string? StudentEnrollmentNo { get; set; }
        public string? Relationship { get; set; }
        public bool? IsValid { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

    }
}
