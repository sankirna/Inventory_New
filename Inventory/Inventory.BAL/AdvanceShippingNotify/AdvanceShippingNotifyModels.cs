using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL.AdvanceShippingNotify
{
    public class AdvanceShippingNotifyModels
    {
        public int ASNID { get; set; }
        public string PONumber { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<System.DateTime> DateOfShipment { get; set; }
        public string ASNNo { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> Status { get; set; }
    }
}