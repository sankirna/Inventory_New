using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.DAL.Country
{
    public class CountryMasterDTO
    {
        public List<CountryMaster> GetList()
        {
            using (var db = new InventoryEntities())
            {
                var lstCountry = (from td in db.CountryMasters where td.Status == 1 select td).ToList();
                return lstCountry;
            }
        }
    }
}