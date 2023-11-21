using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("producttypelocation", Schema = "loyalty")]

    public class ProductTypeLocation:EntityBase
    {
        public ProductTypeLocation() : base() { }
        public int storeLocationId{ get; set; }
        public string ProductTypeCode { get; set; }
        public string ProductTypeName { get; set; }

        [ForeignKey("storeLocationId")]
        public virtual StoreLocation StoreLocation { get; set; }
    }
}
