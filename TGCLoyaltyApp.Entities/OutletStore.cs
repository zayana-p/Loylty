using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("outletstores", Schema = "loyalty")]
    public class OutletStore : EntityBase
    {
        public OutletStore() 
        { }
        public string StoreCode { get; set; }
        public string StoreName { get; set; }
        public virtual ICollection<StoreOrder> StoreOrders { get; set; }

    }
}
