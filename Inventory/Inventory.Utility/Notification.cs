using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Inventory.Utility
{
    public class Notification
    {
        public static void ShowNotification(Page Page, String messaage, NotifyMessge type)
        {
            //string Function = string.Format( "notif({  msg: '{0}',  type: '{1}',width: 'all',  height: 100,  position: 'center'});", "h", "success");
           // Function = string.Format(Function, messaage, type.ToString());

           // System.Web.UI.ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "Script", "notif({ msg: '<b>Success:</b> In 5 seconds i'll be gone',  type: 'success'});", true); 
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "hellosdfhsdfi", "not1('" + type.ToString() +"',' " + messaage + "');", true); 
        }
    }
    public enum NotifyMessge
    {
        success = 1,
        error = 2,
        warning = 3,
        info =4
    }
}