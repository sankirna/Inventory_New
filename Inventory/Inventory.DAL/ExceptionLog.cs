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
    
    public partial class ExceptionLog
    {
        public int ExceptionLogID { get; set; }
        public string ExMessage { get; set; }
        public string ExInnerException { get; set; }
        public Nullable<int> ExCreatedBy { get; set; }
        public Nullable<System.DateTime> ExCreatedDate { get; set; }
        public string ExOrigin { get; set; }
    }
}
