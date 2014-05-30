using System;
using System.Drawing.Printing;
using System.Globalization;

namespace Inventory.Utility
{
    public static class DateUtil
    {
        /// <summary>
        /// Get Current Date
        /// </summary>
        /// <returns></returns>
        public static DateTime GetCurrentDateTime()
        {
            try
            {
                return DateTime.Now;
            }
            catch (Exception ex)
            {
                ex.LogError(typeof(DateUtil));
            }
            return new DateTime();
        }

        public static DateTime GetStringToFormatedDate(this string str)
        {
            try
            {
                return Convert.ToDateTime(DateTime.Parse(str).ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));

            }
            catch (Exception)
            {
                return new DateTime();
            }
        }

        public static string GetForamttedDate(this DateTime dt)
        {
            return dt.ToString("dd-MMM-yy");
        }

    }
}
