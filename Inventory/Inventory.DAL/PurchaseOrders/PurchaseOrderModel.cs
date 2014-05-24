using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.DAL.PurchaseOrders
{
    public class PurchaseOrderModel
    {
        public PurchaseOrderModel()
        {
            PurchaseOrderItems = new List<PurchaseOrderItemModel>();
        }

        public int PurchaseOrderID { get; set; }
        public int SupplierID { get; set; }
        public string PONumber { get; set; }
        public int Status { get; set; }
        public System.DateTime PODate { get; set; }

        public List<PurchaseOrderItemModel> PurchaseOrderItems { get; set; }
    }

    public class PurchaseOrderItemModel
    {
        public PurchaseOrderItemModel()
        {
            Products = new List<ProductPurchaseOrderModel>();
        }
        public int PurchaseOrderDetailID { get; set; }
        public int PurchaseOrderID { get; set; }
        public int ProductID { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }

        public List<ProductPurchaseOrderModel> Products { get; set; }
    }

    public class ProductPurchaseOrderModel
    {
        public int ProductID { get; set; }
        public string Code { get; set; }
        public string BarCode { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string CurrencyCode { get; set; }
        public int QtyPerCarton { get; set; }
    }
}