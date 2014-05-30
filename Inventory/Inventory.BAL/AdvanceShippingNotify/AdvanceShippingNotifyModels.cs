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
        public int PurchaseOrderID { get; set; }
        public string PONumber { get; set; }
        public string PODate { get; set; }

        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ETA { get; set; }
        public string ASNNo { get; set; }
        public string PINo { get; set; }
        public string InvoiceNo { get; set; }
        public decimal TotalM3 { get; set; }
        public int FromCountry { get; set; }
        public int ToCountry { get; set; }
        public string ShippingMethod { get; set; }
        public string TradeTerms { get; set; }

        public List<AdvanceShippingProductDetailModel> AdvanceShippingProductDetails { get; set; }
    }

    public class AdvanceShippingProductDetailModel
    {
        public AdvanceShippingProductDetailModel()
        {
            Products = new List<ProductAdvanceShipping>();
        }

        public int ASNID { get; set; }
        public int AsnProductDetailsId { get; set; }
        public int CartonStartingNo { get; set; }
        public int CartonEndingNo { get; set; }
        public int PurchaseOrderDetailProductId { get; set; }
        public int ProductId { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string BarCode { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public int CountryId { get; set; }
        public string SizeMM { get; set; }
        public string GWKG { get; set; }
        public string NWKG { get; set; }
        public int NoofCartons { get; set; }
        public string WeightCarton { get; set; }
        public int QuantityCarton { get; set; }
        public string MFDate { get; set; }

        public List<CurrencyModel>  CurrencyModels { get; set; }
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

    public class CurrencyModel
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
    }
}