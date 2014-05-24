using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.Utility
{
    public class SessionManager
    {
        public static int UserId
        {
            get { return Convert.ToInt32(HttpContext.Current.Session["userid"]); }
            set { HttpContext.Current.Session["userid"] = value; }
        }

        public static string UserName
        {
            get { return Convert.ToString(HttpContext.Current.Session["username"]); }
            set { HttpContext.Current.Session["username"] = value; }
        }

        public static string UserRole
        {
            get { return Convert.ToString(HttpContext.Current.Session["userrole"]); }
            set { HttpContext.Current.Session["userrole"] = value; }
        }

        public static int ClientMasterID
        {
            get { return Convert.ToInt32(HttpContext.Current.Session["clientmasterId"]); }
            set { HttpContext.Current.Session["clientmasterId"] = value; }
        }
    }
}