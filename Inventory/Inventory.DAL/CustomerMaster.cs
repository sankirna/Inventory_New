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
    
    public partial class CustomerMaster
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string TelePhone { get; set; }
        public string Email { get; set; }
        public Nullable<int> StoreID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
