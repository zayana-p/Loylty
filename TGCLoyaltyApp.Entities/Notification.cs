using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("notifications", Schema = "loyalty")]
    public class Notification : EntityBase
    {
        public Notification() : base()
        {
        }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Path { get; set; }
        public string? DeviceType { get; set; }
    }
}
