using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using modelbal = Inventory.BAL;

namespace Inventory.Web.Purchase
{
    
    public partial class AdvanceShippingList : System.Web.UI.Page
    {
        modelbal.AdvanceShippingNotification advanceShippingNotification = new modelbal.AdvanceShippingNotification();
        modelbal.AdvanceShipping advanceShipping = new modelbal.AdvanceShipping();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            grdAdvanceShipp.DataSource = advanceShipping.GetList();
            grdAdvanceShipp.DataBind();
        }


        protected void btnASN_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdvanceShippingNotify.aspx");
        }  


    }
}