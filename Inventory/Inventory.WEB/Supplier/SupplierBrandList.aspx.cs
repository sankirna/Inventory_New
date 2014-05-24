using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balModel = Inventory.BAL;

namespace Inventory.Web.Supplier
{
    public partial class SupplierBrandList : System.Web.UI.Page
    {
        balModel.SupplierBrand objsupbrand = new balModel.SupplierBrand();
        protected void Page_Load(object sender, EventArgs e)
        {
            grdSupplierBrand.DataSource = objsupbrand.GetList();
            grdSupplierBrand.DataBind();
        }
    }
}