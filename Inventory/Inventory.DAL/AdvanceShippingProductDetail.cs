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
    
    public partial class AdvanceShippingProductDetail
    {
        public int ASNProductDetailsID { get; set; }
        public Nullable<int> ASNID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> CurrencyID { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<System.DateTime> MFDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<int> NoofCartons { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
