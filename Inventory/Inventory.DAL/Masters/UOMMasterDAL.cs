using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.DAL.UOM
{
    public class UOMMasterDTO
    {
        public List<UOMMaster> GetListForDropdown()
        {
            using (var db = new InventoryEntities())
            {
                var objUomList = (from td in db.UOMMasters where td.Status == 1 select td).ToList();
                return objUomList;
            }
        }
    }
}