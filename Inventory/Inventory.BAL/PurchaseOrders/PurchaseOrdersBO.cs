using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.Utility;

namespace Inventory.BAL.PurchaseOrdersBO
{
    public class PurchaseOrdersBO
    {
        public static PurchaseOrderModel GetPurchaseOrder(int PurchaseOrderID)
        {
            try
            {
                return new PurchaseOrderLib().GetPurchaseOrder(PurchaseOrderID);
            }
            catch (Exception ex)
            {
               Helpers.ExceptionHandlerBO.LogException(ex,SessionManager.UserId,"Get Purchase Order Function Purchase Orders BO");
                return null;
            }
        }
        public static string AddUpdatePurchaseOrder(PurchaseOrderModel model)
        {
            try
            {
                return new PurchaseOrderLib().AddUpdatePurchaseOrder(model);
            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex,SessionManager.UserId,"Add Update PurchaseOrder Function Purchase Orders BO");
                return "";
            }
        }
    }
}