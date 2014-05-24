using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL.Model
{
    public class SupplierBrandModel : BaseModel
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }

        public string Description { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string BuildingName { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }

    }
}