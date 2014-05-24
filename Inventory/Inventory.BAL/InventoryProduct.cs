using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.BAL.Model;

namespace Inventory.BAL
{
    public class InventoryProduct
    {
        public List<InventoryProductModel> GetList()
        {
            List<InventoryProductModel> lstInvProduct = new List<InventoryProductModel>();

            for (int i = 0; i < 10; i++)
            {
                lstInvProduct.Add(new InventoryProductModel()
                {
                 Barcode = string.Format("Barcode {0}",i.ToString()),
                 ItemCode = string.Format("Item Code {0}", i.ToString()),
                 Location = string.Format("Location {0}", i.ToString()),
                  PurchaseCost =Convert.ToDouble(200),
                   Qty= i,
                   MFGDate = System.DateTime.Now.AddYears(-1).AddMonths(i).ToShortDateString(),
                   ExpDate = System.DateTime.Now.AddMonths(i).ToShortDateString()
                   
                   

                });
            }

            return lstInvProduct;
        }
    }
}