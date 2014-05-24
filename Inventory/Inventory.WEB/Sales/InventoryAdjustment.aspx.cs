using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balmodel = Inventory.BAL;

namespace Inventory.Web.Sales
{
    public partial class InventoryAdjustment : System.Web.UI.Page
    {
        balmodel.InventoryProduct InvProduct = new balmodel.InventoryProduct();
        protected void Page_Load(object sender, EventArgs e)
        {
            GrdInventoryProduct.DataSource = InvProduct.GetList();
            GrdInventoryProduct.DataBind();
        }
    }
}