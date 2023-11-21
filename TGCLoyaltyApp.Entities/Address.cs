using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("addresses", Schema = "loyalty")]
    public class Address : EntityBase
    {
        public Address() : base()
        { 
        }

        public int CustomerId { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        public string HouseNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string Landmark { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

    }  
}
