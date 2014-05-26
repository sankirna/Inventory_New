using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Utility;
using objdal= Inventory.DAL;
using objbal= Inventory.BAL;

namespace Inventory.Web
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Request.QueryString["CatID"]!=null)
                {
                    objdal.CategoryMaster objCategoryMaster =
                        objbal.Masters.Category.SelectSingleMaster(Request.QueryString["CatID"].ToIntFromString());
                    txtCategoryName.Text = objCategoryMaster.CategoryName;
                    btnSave.Text = "Update";
                }
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                objdal.CategoryMaster objCategoryMaster = new objdal.CategoryMaster();
                objCategoryMaster.CategoryName = txtCategoryName.Text;
                if (Request.QueryString["CatID"]!=null)
                {
                    objCategoryMaster.DateModified = System.DateTime.Now;
                    objCategoryMaster.ModifiedBy = SessionManager.UserId;
                    objCategoryMaster.CategoryID = Request.QueryString["CatID"].ToIntFromString();
                    string result = objbal.Masters.Category.Update(objCategoryMaster);
                    if (result=="suc")
                        
                    {
                        Response.Redirect("CategoryList.aspx");
                    }

                }
                else
                {
                    objCategoryMaster.CreatedBy = SessionManager.UserId;
                    objCategoryMaster.DateCreated = System.DateTime.Now;
                    objCategoryMaster.Status = 1;
                    string result = objbal.Masters.Category.Insert(objCategoryMaster);
                    if (result == "suc")
                    {
                        Response.Redirect("CategoryList.aspx");
                    }    
                }
                

            }
        }
    }
}