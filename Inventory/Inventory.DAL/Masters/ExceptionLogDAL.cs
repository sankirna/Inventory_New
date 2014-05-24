using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Inventory.DAL.Masters
{
    public class ExceptionLogDAL
    {

        public static void AddException(ExceptionLog objExceptionDTO)
        {
            try
            {
                using (var db = new InventoryEntities())
                {
                    db.ExceptionLogs.Add(objExceptionDTO);
                    db.SaveChanges();

                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
           
        }
    }
}