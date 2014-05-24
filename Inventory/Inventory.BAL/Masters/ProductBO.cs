using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.BAL.Model;
using Inventory.Utility;
using ObjDal = Inventory.DAL;

namespace Inventory.BAL
{
    public class Product : DAL.ProductMaster
    {
        public static List<ObjDal.ProductMaster> GetProductList(bool isOnPageLoad, int? startIndex, int? maxRows, int SupplierId)
        {
            try
            {
                return new ObjDal.Masters.ProductDTO().GetProductList(isOnPageLoad, startIndex, maxRows,SupplierId);
            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Get Product List Product BO");
                return null;
            }
        }
        public static int GetProductCount(bool isOnPageLoad,int SupplierID)
        {
            try
            {
                return new ObjDal.Masters.ProductDTO().GetProductCount(isOnPageLoad,SupplierID);
            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Get Product Count Product BO");
                return 0;
            }
        }
        public static string Insert(ObjDal.ProductMaster InsertData)
        {
            try 
    {
        return new ObjDal.Masters.ProductDTO().Insert(InsertData);
    }
    catch (Exception ex)
    {
        Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Product Insert Product BO");
        return "";
    }
        }
        public static ObjDal.ProductMaster GetProductById(int id)
        {
            try
            {
                return new ObjDal.Masters.ProductDTO().BindDataById(id);
            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Get ProductBy Id Product BO");

                return null;
            }
        }

        public static string Update(ObjDal.ProductMaster updateData)
        {
            try
            {
                return new ObjDal.Masters.ProductDTO().Update(updateData);
            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Update Product in Product BO");

                return "";
            }
        }
        public static string Delete (int ProductID)
        {
            try
            {
                return new ObjDal.Masters.ProductDTO().Delete(ProductID);
            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Delete in Product BO");
               return ex.Message.ToString();
            }
        }
    }
}