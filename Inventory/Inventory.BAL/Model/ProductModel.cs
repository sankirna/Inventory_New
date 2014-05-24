using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL.Model
{
    public class ProductModel
    {

        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string MFBarCode { get; set; }
        public int Supplier { get; set; }
        public int UOM { get; set; }
        public float DimenLength { get; set; }
        public float DimenBreadth { get; set; }
        public float DimenHeight { get; set; }
        public float DimenWeight { get; set; }
        public float StdPackingSize { get; set; }
        public float StdPackLength { get; set; }
        public float StdPackBreadth { get; set; }
        public float StdPackHeight { get; set; }
        public float StdPAckWeight { get; set; }
        public int QtyPerCarton { get; set; }
        public decimal PurchaseCost { get; set; }
        public decimal Currency { get; set; }
        public decimal RetailPrice { get; set; }
        public int ShelfLife { get; set; }

    }
}