using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using objdal = Inventory.DAL;
using objbal = Inventory.BAL;
using Inventory.Utility;

namespace Inventory.Web
{
    public partial class Brand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["BrandID"]!=null)
                {
                    objdal.BrandMaster objBrand = objbal.Masters.Brand.SelectSingle(Convert.ToInt32(Request.QueryString["BrandID"]));
                    txtBrandName.Text = objBrand.BrandName;
                    btnSave.Text = "Update";
                    
                }
                
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                objdal.BrandMaster objbrand = new objdal.BrandMaster();
                objbrand.BrandName = txtBrandName.Text;
                if (Request.QueryString["BrandID"]!=null)
                {
                    objbrand.ModifiedBy = SessionManager.UserId;
                    objbrand.DateModified = System.DateTime.Now;
                    objbrand.BrandID = Convert.ToInt32(Request.QueryString["BrandID"]);
                    string objResult = objbal.Masters.Brand.Update(objbrand);
                    if (objResult == "suc")
                    {
                        Response.Redirect("BrandList.aspx?msg=suc&type=Update");
                    }
                    else
                    {
                        Response.Redirect("BrandList.aspx?msg=err&type=Update");
                    }
                }
                else
                {
                    objbrand.CreatedBy = SessionManager.UserId;
                    objbrand.DateCreated = System.DateTime.Now;
                    objbrand.Status = 1;
                    string objResult = objbal.Masters.Brand.Insert(objbrand);
                    if (objResult == "suc")
                    {
                        Response.Redirect("BrandList.aspx?msg=suc&type=insert");
                    }
                    else
                    {
                        Response.Redirect("BrandList.aspx?msg=err&type=insert");
                    }
                }
                
            }
        }
    }
}