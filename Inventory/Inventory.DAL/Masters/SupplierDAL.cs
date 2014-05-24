using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.DAL.Supplier
{
    public class SupplierDTO
    {
        public List<SupplierMaster> GetListForDDL()
        {
            using (var db = new DAL.InventoryEntities())
            {
                var ObjSupplierList = (from td in db.SupplierMasters select td).ToList();
                return ObjSupplierList;
                
            }
        }
    }
}