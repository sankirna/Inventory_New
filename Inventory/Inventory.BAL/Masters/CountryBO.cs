using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using objdal = Inventory.DAL;
using Inventory.Utility;

namespace Inventory.BAL
{
    public class Country
    {
        public static List<objdal.CountryMaster> GetList()
        {
            try
            {
                return new objdal.Country.CountryMasterDTO().GetList();

            }
            catch (Exception ex)
            {

                Helpers.ExceptionHandlerBO.LogException(ex,SessionManager.UserId, "GetList CountryBAL");
                return null;
            }
           
        }
    }
}