using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balmodel = Inventory.BAL;


namespace Inventory.Web.Sales
{
    public partial class PickingList : System.Web.UI.Page
    {
        balmodel.InventoryProduct InvProduct = new balmodel.InventoryProduct();
        protected void Page_Load(object sender, EventArgs e)
        {
            drpItemCode.Attributes.Add("onchange", "return Show()");
            GrdInventoryProduct.DataSource = InvProduct.GetList();
            GrdInventoryProduct.DataBind();
            GrdPickingListProduct.DataSource = InvProduct.GetList();
            GrdPickingListProduct.DataBind();
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
          
        }
    }
}