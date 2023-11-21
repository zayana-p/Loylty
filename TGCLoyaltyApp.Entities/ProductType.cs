using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Entities
{
    [Table("producttypes", Schema = "loyalty")]
    public class ProductType:EntityBase
    {
        public ProductType():base()
        { }
        public string ProductTypeCode { get; set; }
        public string ProductTypeName { get; set; }
    }
}
