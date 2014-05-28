using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.DAL;
using Inventory.DAL.PurchaseOrders;
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

        public static List<PurchaseOrder> GetList(int supplierId, string pOnumber, string startDate, string endDate,
            bool onPageload, int? startIndex, int? maxRows)
        {
            try
            {
                return new PurchaseOrderLib().GetList(supplierId, pOnumber, startDate, endDate, onPageload, startIndex,
                    maxRows);
            }
            catch (Exception ex)
            {
                    Helpers.ExceptionHandlerBO.LogException(ex,SessionManager.UserId,"Get List PO Business Class");
                return null;
            }
        }

        public static int GetPoCount(int supplierId, string pOnumber, string startDate, string endDate, bool onPageload)
        {
            try
            {
                return new PurchaseOrderLib().GetPoCount(supplierId, pOnumber, startDate, endDate, onPageload);
            }
            catch (Exception ex)
            {
                    Helpers.ExceptionHandlerBO.LogException(ex,SessionManager.UserId,"Get PO Count Business Logic");
                return 0;
            }
        }
    }
}