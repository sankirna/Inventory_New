using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL
{
    public class Store
    {
        public List<StoreModel> GetList()
        {
            List<StoreModel> lstStore = new List<StoreModel>();

            for (int i = 0; i < 10; i++)
            {
                lstStore.Add(new StoreModel()
                {

                    Id = i,
                    StoreName = string.Format("StoreName {0} ", i.ToString()),
                    ContactNo = string.Format("ContactNo    {0} ", i.ToString()),
                    Email = string.Format("Email        {0} ", i.ToString()),
                    Address1 = string.Format("Address1     {0} ", i.ToString()),
                    Address2 = string.Format("Address2     {0} ", i.ToString()),
                    Address3 = string.Format("Address3     {0} ", i.ToString()),

                });
            }

            return lstStore;
        }
    }
}