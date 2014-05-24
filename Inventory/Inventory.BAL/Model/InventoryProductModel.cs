using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL.Model
{
    public class InventoryProductModel:BaseModel
    {
        public string ItemCode { get; set; }
        public string Barcode { get; set; }
        public string Location { get; set; }
        public double PurchaseCost { get; set; }
        public int Qty { get; set; }
        public string MFGDate { get; set; }
        public string ExpDate { get; set; }
    }
}