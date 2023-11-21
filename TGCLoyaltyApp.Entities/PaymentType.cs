using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("paymenttypes", Schema = "loyalty")]
    public class PaymentType : EntityBase
    {
        public PaymentType() : base()
        {
        }
        public string TypeCode { get; set; }
        public string TypeName { get; set; }
        public virtual ICollection<PaymentType> PaymentTypes { get; set; }
    }
}
