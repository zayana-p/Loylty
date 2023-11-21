using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("serviceaccess", Schema = "loyalty")]
    public class ServiceAccess : EntityBase
    {
        public ServiceAccess() : base()
        {
        }
        public int UserId { get; set; }
        public string ServiceTypeCode { get; set; }
        public string ServiceTypeName { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
