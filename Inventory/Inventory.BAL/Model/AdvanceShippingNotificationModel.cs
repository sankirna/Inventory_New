﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL.Model
{
    public class AdvanceShippingNotificationModel
    {
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public double Qty { get; set; }
        public double Amount { get; set; }
        public string BarCodeNO { get; set; }
        public int NoofCartons { get; set; }
        public double TotalQuantity { get; set; }
        public string MfgDate { get; set; }
        public string ExpiryDate { get; set; }
    }
  
        
}