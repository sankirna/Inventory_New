using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL.Model
{
    public class CustomerReturnNoteModel
    {
        public string ItemCode { get; set; }
        public string Qty { get; set; }
        public string location { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
    }
}