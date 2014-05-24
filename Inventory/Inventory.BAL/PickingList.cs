using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.BAL.Model;

namespace Inventory.BAL
{
    public class PickingList
    {
        public List<PickingListModel> GetList()
        {
            List<PickingListModel> lstPickingList = new List<PickingListModel>();
            string[] names = new string[] { "Tracy", "Adrian", "Angel", "Regina", "Mae", "Sharon", "Bernard", "Brian", "Enedina", "Loretta" };
            for (int i = 0; i < 10; i++)
            {
                lstPickingList.Add(new PickingListModel()
                {
                     CustomerName= names[i],
                     SalesOrderId=System.DateTime.Now.Month+System.DateTime.Now.Millisecond+i.ToString(),
                     StoreName= string.Format("Store name {0}",i.ToString())
               



                });
            }

            return lstPickingList;
        }
    }
}