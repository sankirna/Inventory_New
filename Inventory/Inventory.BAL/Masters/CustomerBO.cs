using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.BAL.Model;


namespace Inventory.BAL
{
    public class Customer : CustomerModel
    {
        public List<CustomerModel> GetList()
        {
            List<CustomerModel> lstPickingList = new List<CustomerModel>();
            string[] names = new string[] { "Tracy", "Adrian", "Angel", "Regina", "Mae", "Sharon", "Bernard", "Brian", "Enedina", "Loretta" };
            for (int i = 0; i < 10; i++)
            {
                lstPickingList.Add(new CustomerModel()
                {
                    CustomerName = names[i],
                    Address1 = string.Format("Address1 {0}", i.ToString()),
                    Address2 = string.Format("Address2 {0}", i.ToString()),
                    City = string.Format("City {0}", i.ToString()),
                    Country =string.Format("Country {0}",i.ToString()),
                    Email=string.Format("Email {0}",i.ToString()),
                    Store = i,
                    Street = string.Format("Street{0}", i.ToString()),
                    TelephoneNo =i +23456745
                    


                });
            }

            return lstPickingList;

        }
    }
}