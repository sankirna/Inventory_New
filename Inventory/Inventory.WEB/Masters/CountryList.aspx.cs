using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balModel = Inventory.BAL;
namespace Inventory.Web
{
    public partial class CountryList : System.Web.UI.Page
    {
        balModel.Country contry = new balModel.Country();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
              //  GrdCountry.DataSource = contry.GetList();
               // GrdCountry.DataBind();
            }
        }
    }
}