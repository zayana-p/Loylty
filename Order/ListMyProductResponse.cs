using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class ListMyProductResponse : ResponseBase
    {
        public ListMyProductResponse() { }
        public List<MyProducts>? myProducts { get; set; }
    }
}
