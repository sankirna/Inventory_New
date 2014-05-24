using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balModel = Inventory.BAL;

namespace Inventory.Web
{
    public partial class CategoryList : System.Web.UI.Page
    {
        balModel.Category contry = new balModel.Category();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                GrdCategory.DataSource = contry.GetList();
                GrdCategory.DataBind();
            }
        }
    }
}