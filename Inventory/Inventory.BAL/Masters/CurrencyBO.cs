using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.Utility;
using objDal = Inventory.DAL;

namespace Inventory.BAL
{
    public class Currency
    {
        public static List<objDal.CurrencyMaster> GetList()
        {
            try
            {
                return new objDal.Currency.CurrencyDTO().GetList();
            }
            catch (Exception ex)
            {
                Helpers.ExceptionHandlerBO.LogException(ex, SessionManager.UserId, "Get List CurrencyBO");

                return null;
            }
           
        }
    }
}