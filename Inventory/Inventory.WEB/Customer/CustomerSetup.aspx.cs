using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balModel = Inventory.BAL;
using Inventory.Utility;


namespace Inventory.Web.Customer
{
    public partial class CustomerSetup : System.Web.UI.Page
    {
        balModel.Country country = new balModel.Country();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
             //   drpCountry = drpCountry.BindDropDown(country.GetList(), "Name", "Id");

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}