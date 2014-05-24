using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using objdal=Inventory.DAL;
using Inventory.Utility;

namespace Inventory.BAL
{
    public class SupplierBrand
    {
        public List<SupplierBrandModel> GetList()
        {
            List<SupplierBrandModel> lstSupplierBrand = new List<SupplierBrandModel>();

            for (int i = 0; i < 10; i++)
            {
                lstSupplierBrand.Add(new SupplierBrandModel()
                {

                    Id = i,
                    BrandId = i + 100,
                    SupplierName = string.Format("SupplierName {0} ", i.ToString()),
                    Description = string.Format("Description  {0} ", i.ToString()),
                    ContactNo = string.Format("ContactNo    {0} ", i.ToString()),
                    Email = string.Format("Email        {0} ", i.ToString()),
                    Address1 = string.Format("Address1     {0} ", i.ToString()),
                    BuildingName = string.Format("BuildingName {0} ", i.ToString()),
                    Street = string.Format("Street       {0} ", i.ToString()),
                    State = string.Format("State        {0} ", i.ToString()),
                    City = string.Format("City         {0} ", i.ToString()),
                    Country = string.Format("Country      {0} ", i.ToString()),
                    BrandName = string.Format("BrandName   {0} ", i.ToString()),

                });
            }

            return lstSupplierBrand;
        }
        public static List<objdal.SupplierMaster> GetListForDDL()
        {
            try
            {
                return new objdal.Supplier.SupplierDTO().GetListForDDL();

            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Supplier List for DropDown Supplier BO");
                return null;
            }
        }
    }
}