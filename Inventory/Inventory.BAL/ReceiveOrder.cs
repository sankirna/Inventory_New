using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL
{
    public class ReceiveOrder
    {
        public List<ReceiveOrderModel> GetList()
        {
            List<ReceiveOrderModel> lstReceiveOrderModel = new List<ReceiveOrderModel>();
            string[] names = new string[] { "Tracy", "Adrian", "Angel", "Regina", "Mae", "Sharon", "Bernard", "Brian", "Enedina", "Loretta" };

            for (int i = 0; i < 10; i++)
            {
                lstReceiveOrderModel.Add(new ReceiveOrderModel()
                {
                    ASNNo = string.Format("ASN{0}", i),
                    PONo = "DEPO20141205",
                    SupplierName = names[i],
                    DateCreated = System.DateTime.Now.AddYears(i).AddMonths(i).ToShortDateString(),
                    CreatedBy="Admin"

                });
            }

            return lstReceiveOrderModel;
        }
    }
}