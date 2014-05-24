using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.Utility;
using objdal = Inventory.DAL;

namespace Inventory.BAL
{
    public class UOMaster
    {
        public static List<objdal.UOMMaster> GetDataForDropdown()
        {
            try
            {
                return new objdal.UOM.UOMMasterDTO().GetListForDropdown();

            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Get Data For Dropdown UOM BO");

                return null;
            }
        }
    }
}