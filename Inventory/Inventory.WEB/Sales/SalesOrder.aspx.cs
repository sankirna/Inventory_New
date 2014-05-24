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
    public partial class SalesOrder : System.Web.UI.Page
    {
        balModel.Customer customer = new balModel.Customer();
        balModel.Store store = new balModel.Store();
        Product product = new Product();
        balModel.PurchaseSupplierOrder purchaseSupplierOrder = new balModel.PurchaseSupplierOrder();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               drpCutmrNam = drpCutmrNam.BindDropDown(customer.GetList(), "CustomerName", "CustomerId");
               drpStoreNm.BindDropDown(store.GetList(), "StoreName", "Id");
               grdItem.DataSource = purchaseSupplierOrder.GetList();
               grdItem.DataBind();
            }
        }
    }
}