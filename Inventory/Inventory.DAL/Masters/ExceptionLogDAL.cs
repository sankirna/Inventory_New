using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.DAL.Masters
{
    public class ExceptionLogDAL
    {

        public static void AddException(ExceptionLog objExceptionDTO)
        {
            using (var db = new InventoryEntities())
            {
                db.ExceptionLogs.Add(objExceptionDTO);
                db.SaveChanges();
                
            }
        }
    }
}