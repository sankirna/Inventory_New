using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using objdal= Inventory.DAL;

namespace Inventory.BAL.Helpers
{
    public class ExceptionHandlerBO
    {
        public static void LogException(Exception ex)
        {
            //Default user from Back office
            LogException(ex, 100, "");
            throw ex;
        }

        public static void LogException(Exception ex, int user, string origin)
        {
            objdal.ExceptionLog objExceptionDTO = new objdal.ExceptionLog();
            objExceptionDTO.ExMessage = ex.Message;
            objExceptionDTO.ExInnerException = ex.StackTrace;
            objExceptionDTO.ExCreatedBy = user;
            objExceptionDTO.ExCreatedDate = DateTime.Now;
            objExceptionDTO.ExOrigin = origin;
            objdal.Masters.ExceptionLogDAL.AddException(objExceptionDTO);
        }
    }
}