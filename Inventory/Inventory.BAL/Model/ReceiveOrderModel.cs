using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL.Model
{
    public class ReceiveOrderModel :BaseModel
    {
        public string SupplierName { get; set; }
        public string ASNNo { get; set; }
        public string PONo { get; set; }
        public string RTagNO { get; set; }
        public string DateCreated { get; set; }
        public string CreatedBy { get; set; }

    }
}