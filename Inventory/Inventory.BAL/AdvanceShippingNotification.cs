using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL
{
    public class AdvanceShippingNotification
        {
            public List<AdvanceShippingNotificationModel> GetList()
            {
                List<AdvanceShippingNotificationModel> lstAdvanceShippingNotificationModel = new List<AdvanceShippingNotificationModel>();

            for (int i = 0; i < 10; i++)
            {
                lstAdvanceShippingNotificationModel.Add(new AdvanceShippingNotificationModel()
                {

                    ItemCode = Guid.NewGuid().ToString().Substring(0, 4),
                    Description = string.Format("Description  {0} ", i.ToString()),
                    UnitPrice = 200 + i,
                    Qty = 200 + i,
                    Amount = 200 + i,
                    BarCodeNO = string.Format("BarCodeNO  {0} ", i.ToString()),
                    NoofCartons = 20 + 1,
                    TotalQuantity = 10 + i,
                    MfgDate = System.DateTime.Now.AddMonths(i).ToShortDateString(),
                    ExpiryDate = System.DateTime.Now.AddYears(i).AddMonths(i).ToShortDateString(),

                });
            }

            return lstAdvanceShippingNotificationModel;
        }
        
    }
    //public class AdvanceShipping
    //{
    //    public List<AdvanceShippingModel> GetList()
    //    {
    //        string[] names = new string[] { "Tracy", "Adrian", "Angel", "Regina", "Mae", "Sharon", "Bernard", "Brian", "Enedina", "Loretta" };
    //        List<AdvanceShippingModel> lstAdvanceShippingNotificationModel = new List<AdvanceShippingModel>();

    //        for (int i = 0; i < 10; i++)
    //        {
    //            lstAdvanceShippingNotificationModel.Add(new AdvanceShippingModel()
    //            {
    //              Supplier=names[i],
    //              PONumber= "DEPO20141405",
    //              PODate="14-May-2015",
    //              ASNNO="ASN0001"

    //            });
    //        }

    //        return lstAdvanceShippingNotificationModel;
    //    }
       
    //    }
}