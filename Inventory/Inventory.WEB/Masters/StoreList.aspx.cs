using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balModel = Inventory.BAL;

namespace Inventory.Web
{
    public partial class StoreList : System.Web.UI.Page
    {
        balModel.Store contry = new balModel.Store();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GrdStore.DataSource = contry.GetList();
                GrdStore.DataBind();
            }
        }
    }
}
