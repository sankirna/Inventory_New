using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL.Model
{
    public class SupplierPurchaseOrderModel : BaseModel
    {
        public string PONumber { get; set; }
        public string SupplierName { get; set; }
        public string DateCreated { get; set; }
        public string CreatedBy { get; set; }

    }

    public class PurchaseOrderItemModel : BaseModel
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string BarCode { get; set; }
        public double PurchaseCost { get; set; }
        public double Cost { get; set; }
        public double Quantity { get; set; }
        public double Amount { get; set; }
    }
}