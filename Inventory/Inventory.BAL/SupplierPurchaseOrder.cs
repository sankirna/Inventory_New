using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL
{
    public class SupplierPurchaseOrder
    {
        public List<SupplierPurchaseOrderModel> GetList()
        {
            List<SupplierPurchaseOrderModel> lstInvProduct = new List<SupplierPurchaseOrderModel>();
            string[] names = new string[] { "Tracy", "Adrian", "Angel", "Regina", "Mae", "Sharon", "Bernard", "Brian", "Enedina", "Loretta" };
            for (int i = 0; i < 10; i++)
            {
                lstInvProduct.Add(new SupplierPurchaseOrderModel()
                {
                    PONumber = string.Format("DEPO20141205"),
                    SupplierName = names[i],
                    DateCreated = System.DateTime.Now.AddMonths(i).ToShortDateString(),
                    CreatedBy="Admin"
                });
            }

            return lstInvProduct;
        }
    }


    public class PurchaseOrderItem
    {
        public List<PurchaseOrderItemModel> GetList()
        {
            List<PurchaseOrderItemModel> lstInvProduct = new List<PurchaseOrderItemModel>();

            for (int i = 0; i < 10; i++)
            {
                lstInvProduct.Add(new PurchaseOrderItemModel()
                {
                    ItemId = i,
                    ItemCode = string.Format("ItemCode {0}", i.ToString()),
                    ItemDescription = string.Format("Item Description {0}", i.ToString()),
                    BarCode = string.Format("BarCode {0}", i.ToString()),
                    PurchaseCost = 60 + i,
                    Cost = 50 + i,
                    Quantity = 5 + i,
                    Amount = 50 + i,
                });
            }

            return lstInvProduct;
        }
    }
}