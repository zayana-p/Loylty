using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("pushnotifications", Schema = "loyalty")]
    public class PushNotification : EntityBase
    {
        public PushNotification() : base()
        {
        }
        public int CustomerId { get; set; }
        public string DeviceType { get; set; }
        public string Token { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
