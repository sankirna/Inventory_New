using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balModel = Inventory.BAL;

namespace Inventory.Web
{
    public partial class CustomerSkuList : System.Web.UI.Page
    {
        balModel.CustomerSku customerSku = new balModel.CustomerSku();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GrdCustomerSku.DataSource = customerSku.GetList();
                GrdCustomerSku.DataBind();
            }
        }
    }
}
