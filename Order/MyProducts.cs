using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class MyProducts
    {
        public MyProducts()
        {

        }
        public string CustomerName { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string OrderNo { get; set; }
    }
}
