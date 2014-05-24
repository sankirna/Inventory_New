using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.BAL.Model;
namespace Inventory.BAL
{
    public class CustomerReturnNote
    {
        public List<CustomerReturnNoteModel> GetList()
        {
            List<CustomerReturnNoteModel> lstPickingList = new List<CustomerReturnNoteModel>();
          //  string[] names = new string[] { "Tracy", "Adrian", "Angel", "Regina", "Mae", "Sharon", "Bernard", "Brian", "Enedina", "Loretta" };
            for (int i = 0; i < 10; i++)
            {
                lstPickingList.Add(new CustomerReturnNoteModel()
                {
                    
                   ItemCode = Guid.NewGuid().ToString().Substring(0, 4),
                   location= string.Format("Location{0}", i.ToString()),
                   Notes=string.Format("Notes{0}", i.ToString()),
                   Qty =i.ToString(),
                   Status= i.ToString()


                });
            }

            return lstPickingList;

        }
    }
}