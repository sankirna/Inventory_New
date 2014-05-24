using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using objdal = Inventory.DAL;
using Inventory.Utility;

namespace Inventory.BAL.Masters
{
    public class Brand
    {
        public static List<objdal.BrandMaster> GetBrandList( int? startIndex, int? maxRows)
        {
            try
            {
                return new objdal.Masters.BrandMasterDAL().GetBrandList( startIndex, maxRows);
               
            }
            catch (Exception ex)
            {
                
                 Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Get Brand List Brand BO");
                return null;
            }
        }
        public static string Insert(DAL.BrandMaster objBrand)
        {
            try
            {
                return new objdal.Masters.BrandMasterDAL().Insert(objBrand);

            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Brand Insert Brand BO");
                return null ;
            }
        }
        public static int GetBrandCount()
        {
            try
            {
                return new objdal.Masters.BrandMasterDAL().GetBrandCount();

            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Get Brand Count in Brand BO");
                return 0;
            }
        }
        public static objdal.BrandMaster SelectSingle(int BrandID)
        {
            try
            {
                return new objdal.Masters.BrandMasterDAL().SelectSingle(BrandID);
            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Select Single Brand BO");
                return null;
            }
        }
        public static string Update(objdal.BrandMaster objBrandUpdate)
        {
            try
            {
                return new objdal.Masters.BrandMasterDAL().Update(objBrandUpdate);
            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Update Brand BO");
                return "";
                
               
            }
        }
    }
}