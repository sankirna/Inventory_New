using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL.Model
{
    public class PurchaseSupplierOrderModel :BaseModel
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }

        public int ProductId { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }

        public string BarCode { get; set; }
        public decimal PurchaseCost { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}