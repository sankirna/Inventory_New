using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL
{
    public class PurchaseSupplierOrder
    {
        public List<PurchaseSupplierOrderModel> GetList()
        {
            List<PurchaseSupplierOrderModel> lstPurchaseSupplierOrder = new List<PurchaseSupplierOrderModel>();

            for (int i = 0; i < 10; i++)
            {
                lstPurchaseSupplierOrder.Add(new PurchaseSupplierOrderModel()
                {
                     
                    Id = i,
                    SupplierName = string.Format("SupplierName {0} ", i.ToString()),
                    ProductId =i+100,
                    ItemCode = Guid.NewGuid().ToString().Substring(0,4),
                    ItemDescription = string.Format("Description  {0} ", i.ToString()),
                    BarCode = Guid.NewGuid().ToString(),
                    PurchaseCost =200+i,
                    Cost = 200+i,
                    Quantity =2+i,
                    Amount = 600+i,

                });
            }

            return lstPurchaseSupplierOrder;
        }

    }
}