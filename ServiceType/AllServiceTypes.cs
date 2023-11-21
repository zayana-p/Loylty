using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGCLoyaltyApp.Core.ViewModels
{
    public class AllServiceTypes
    {
        public AllServiceTypes() { }
        public string Code { get; set; }
        public string Name { get; set; }
        public List<Status> statuses { get; set; }
    }
}
