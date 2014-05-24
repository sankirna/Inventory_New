using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL
{
    public class CustomerSkuModel : BaseModel
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public string ItemCode { get; set; }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public int StoreId { get; set; }
        public string StoreName { get; set; }

        public string CustomerSkuCode { get; set; }

    }
}