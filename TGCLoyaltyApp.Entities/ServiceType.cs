using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("servicetypes", Schema = "loyalty")]
    public class ServiceType : EntityBase
    {
        public ServiceType() : base()
        { }
        public string Code { get; set; }    
        public string Name { get; set; }
        public virtual ICollection<Status> Status { get; set; }

    }
}
