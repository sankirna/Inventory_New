//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseOrderDetail
    {
        public int PurchaseOrderDetailID { get; set; }
        public Nullable<int> PurchaseOrderID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Amount { get; set; }
    
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
