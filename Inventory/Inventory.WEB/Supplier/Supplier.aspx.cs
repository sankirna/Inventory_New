using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balModel = Inventory.BAL;
using Inventory.Utility;

namespace Inventory.Web
{
    public partial class SupplierBrand : System.Web.UI.Page
    {
       // balModel.Brand brand = new balModel.Brand();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //drpBrandNames=drpBrandNames.BindDropDown(brand.GetList(), "Name", "Id");
               Notification.ShowNotification(this, "hello", NotifyMessge.error);
                //ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "hellosdfhsdfi", "not1('success','hellllllllo');", true); 
               
               // this.Master.ShowMessage("a", "a");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "hellosdfhsdfi", "not1('success','hellllllllo');", true); 
            //System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "Script", "notif({ msg: '<b>Success:</b> In 5 seconds ill be gone',  type: 'success'});", true); 
        }
    }
}