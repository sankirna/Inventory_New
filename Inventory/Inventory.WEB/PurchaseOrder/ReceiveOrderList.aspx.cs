using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balmodel = Inventory.BAL;


namespace Inventory.Web.PurchaseOrder
{
    public partial class ReceiveOrderList : System.Web.UI.Page
    {

        balmodel.ReceiveOrder lstReceiveOrder = new balmodel.ReceiveOrder();
        balmodel.AdvanceShippingNotification advanceShippingNotification = new balmodel.AdvanceShippingNotification();
        protected void Page_Load(object sender, EventArgs e)
        {

            grdReceiveList.DataSource = lstReceiveOrder.GetList();
            grdReceiveList.DataBind();
           
        }
    }
}