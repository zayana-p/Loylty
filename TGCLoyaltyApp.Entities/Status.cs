using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("statuses", Schema = "loyalty")]
    public class Status : EntityBase
    {
        public Status() : base()
        {

        }
        public int ServiceTypeId { get; set; }
        public string ServiceTypeName { get; set; }
        public string StatusData { get; set; }
        public int SequenceNumber { get; set; }
        [ForeignKey("ServiceTypeId")]
        public virtual ServiceType ServiceType { get; set; }
    }
}
