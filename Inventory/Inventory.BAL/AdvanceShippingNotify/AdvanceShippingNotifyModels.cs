using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL.AdvanceShippingNotify
{
    public class AdvanceShippingNotifyModels
    {
        public AdvanceShippingNotifyModels()
        {
            AdvanceShippingProductDetails = new List<AdvanceShippingProductDetailModel>();
        }
        public int ASNID { get; set; }
        public string PONumber { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public string SupplierName { get; set; }
        public Nullable<System.DateTime> DateOfShipment { get; set; }
        public string ASNNo { get; set; }

        public List<AdvanceShippingProductDetailModel> AdvanceShippingProductDetails { get; set; }
    }

    public class AdvanceShippingProductDetailModel
    {
        public AdvanceShippingProductDetailModel()
        {
            Products = new List<ProductAdvanceShipping>();
        }
        public int ASNProductDetailsID { get; set; }
        public Nullable<int> ASNID { get; set; }
        public int ProductID { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public Nullable<int> Qty { get; set; }
        public string MFDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<int> NoofCartons { get; set; }
        public Nullable<decimal> Rate { get; set; }

        public List<ProductAdvanceShipping> Products { get; set; }
    }

    public class ProductAdvanceShipping
    {
        public int ProductID { get; set; }
        public string Code { get; set; }
        public string BarCode { get; set; }
        public string Description { get; set; }

        public decimal? Cost { get; set; }
        public int? Quantity { get; set; }
        public decimal? Amount { get; set; }

        public string CurrencyCode { get; set; }
        public int QtyPerCarton { get; set; }
    }
}