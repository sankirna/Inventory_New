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
    public partial class CustomerSku : System.Web.UI.Page
    {
        balModel.PurchaseSupplierOrder purchaseSupplierOrder = new balModel.PurchaseSupplierOrder();
        balModel.Store store = new balModel.Store();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                drpItemCode.BindDropDown(purchaseSupplierOrder.GetList(), "ItemCode", "ItemCode");
                drpStore.BindDropDown(store.GetList(), "StoreName", "Id");
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}