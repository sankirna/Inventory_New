using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL.Model
{
    public class PickingListModel:BaseModel
    {
        public string SalesOrderId { get; set; }
        public string CustomerName { get; set; }
        public string StoreName { get; set; }
    }
}