using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL
{
    public class CustomerSku
    {
        public List<CustomerSkuModel> GetList()
        {
            List<CustomerSkuModel> lstStore = new List<CustomerSkuModel>();

            for (int i = 0; i < 10; i++)
            {
                lstStore.Add(new CustomerSkuModel()
                {
                    Id = i,

                    ProductId = 100 + i,
                    ItemCode = Guid.NewGuid().ToString().Substring(0, 4),

                    CustomerId = 200 + i,
                    CustomerName = string.Format("CustomerName {0} ", i.ToString()),

                    StoreId = 300 + i,
                    StoreName = string.Format("StoreName {0} ", i.ToString()),

                    CustomerSkuCode = Guid.NewGuid().ToString().Substring(0, 8),
                });
            }

            return lstStore;
        }
    }
}