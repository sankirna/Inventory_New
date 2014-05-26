using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.Utility;
using objdal=Inventory.DAL;

namespace Inventory.BAL.Masters

{
    public class Category
    {
        public static List<objdal.CategoryMaster> GetList(int? pageIndex,int? maxRows)
        {
            try
            {
                return new objdal.Masters.CategoryMasterDAL().GetList( pageIndex, maxRows);
            }
            catch (Exception ex)
            {
                  Helpers.ExceptionHandlerBO.LogException(ex,SessionManager.UserId,"Get List Category BO");
                return null;
            }
        }

        public static int GetCategoryCount()
        {
            try
            {
                return new objdal.Masters.CategoryMasterDAL().GetCategoryCount();
            }
            catch (Exception ex)
            {
                    
                Helpers.ExceptionHandlerBO.LogException(ex,SessionManager.UserId,"Get Category Count BO");
                return 0;
            }
        }
        public static string Insert(objdal.CategoryMaster insCategoryMaster)
        {
            try
            {
                return new objdal.Masters.CategoryMasterDAL().Insert(insCategoryMaster);
            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex,SessionManager.UserId,"Category Insert BO");
                return null;

            }
        }

        public static objdal.CategoryMaster SelectSingleMaster(int categoryId)
        {
            try
            {
                return new objdal.Masters.CategoryMasterDAL().SelectSingleMaster(categoryId);
            }
            catch (Exception ex)
            {
                    
               Helpers.ExceptionHandlerBO.LogException(ex,SessionManager.UserId,"Select Single Category BO");
                return null;
            }
        }

        public static string Delete(int categoryId)
        {
            try
            {
                return new objdal.Masters.CategoryMasterDAL().Delete(categoryId);
            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex,SessionManager.UserId,"Delete Category BO");
                return null;
            }
        }

        public static string Update(objdal.CategoryMaster updateCategoryMaster)
        {
            try
            {
                return new objdal.Masters.CategoryMasterDAL().Update(updateCategoryMaster);
            }
            catch (Exception ex)
            {
                    
              Helpers.ExceptionHandlerBO.LogException(ex,SessionManager.UserId,"Update Category BO");
                return null;
            }
        }
    }
}