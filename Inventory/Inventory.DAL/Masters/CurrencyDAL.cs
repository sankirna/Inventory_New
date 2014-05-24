using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.DAL.Currency
{
    public class CurrencyDTO
    {
        public List<CurrencyMaster> GetList()
        {
            using (var db = new InventoryEntities())
            {
                var LstCurrency = (from td in db.CurrencyMasters where td.Status == 1 select td).ToList();
                return LstCurrency;
            }
        }
    }
}