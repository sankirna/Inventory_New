using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balModel = Inventory.BAL;

namespace Inventory.Web
{
    public partial class PurchaseSupplierOrderList : System.Web.UI.Page
    {
        balModel.PurchaseSupplierOrder purchaseSupplierOrder = new balModel.PurchaseSupplierOrder();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GrdSupplierBrand.DataSource = purchaseSupplierOrder.GetList();
                GrdSupplierBrand.DataBind();
            }
        }
    }
}
