using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balmodel = Inventory.BAL;

namespace Inventory.Web.Sales
{
    public partial class ReturnNotesList : System.Web.UI.Page
    {
        balmodel.CustomerReturnNote objrerurnnotes = new balmodel.CustomerReturnNote();
        protected void Page_Load(object sender, EventArgs e)
        {
            GrdInventoryProduct.DataSource = objrerurnnotes.GetList();
            GrdInventoryProduct.DataBind();
        }
    }
}