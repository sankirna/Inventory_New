using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balModel = Inventory.BAL;

namespace Inventory.Web.Customer
{
    public partial class CustomerList : System.Web.UI.Page
    {
        balModel.Customer cust = new balModel.Customer();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GrdCusomer.DataSource = cust.GetList();
                GrdCusomer.DataBind();
            }

        }
    }
}