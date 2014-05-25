using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balModel = Inventory.BAL;
using objdal = Inventory.DAL;
using Inventory.Utility;

namespace Inventory.Web
{
    public partial class CategoryList : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            int Pagesize = 0;
            int pageButtonCount = 0;
            Pager.OnPageIndexChanging += Pager_OnPageIndexChanging;
            Pagesize = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["PAGESIZE"]);
            pageButtonCount = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["PAGEBUTTONCOUNT"]);
            hdnPageSize.Value = Pagesize.ToString();
            hdnPageButtonCount.Value = pageButtonCount.ToString();
            if (!Page.IsPostBack)
            {
                hdnTotalRecords.Value = string.Empty;
                hdnCurrentPageIndex.Value = "0";
                BindGrid(0);
             
            }
        }

        private void Pager_OnPageIndexChanging(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            hdnCurrentPageIndex.Value = index.ToString();

            BindGrid(index);
        }

        void BindGrid( int index)
        {

            List<objdal.CategoryMaster> lstCategoryMasters = balModel.Masters.Category.GetList(index, Convert.ToInt32(hdnPageSize.Value));
            if (lstCategoryMasters != null && lstCategoryMasters.Count > 0)
            {
                int totalrecords = balModel.Masters.Category.GetCategoryCount();
                hdnTotalRecords.Value = totalrecords.ToString();
                lblNoRecords.Text = "Total Records : " + hdnTotalRecords.Value;
                GrdCategory.PageSize = Convert.ToInt32(hdnPageSize.Value);
                GrdCategory.DataSource = lstCategoryMasters;
                GrdCategory.DataBind();
                GrdCategory.PageIndex = Convert.ToInt32(hdnCurrentPageIndex.Value);
                GrdCategory.PagerSettings.PageButtonCount = Convert.ToInt32(hdnPageButtonCount.Value);
                int totalpages = totalrecords / Convert.ToInt32(hdnPageSize.Value);
                if (totalrecords % Convert.ToInt32(hdnPageSize.Value.ToString()) > 0)
                {
                    totalrecords += 1;
                }
                if (totalrecords < 1)
                    CurrentPageNo.Text = "Page : 0/0";
                else
                    CurrentPageNo.Text = "Page : " + (GrdCategory.PageIndex + 1).ToString(System.Globalization.CultureInfo.InstalledUICulture) + "/" + totalpages.ToString(System.Globalization.CultureInfo.InstalledUICulture);
                //Recreating the pager as per page index
                Pager.LoadPager(Convert.ToInt32(hdnCurrentPageIndex.Value), totalrecords, Convert.ToInt32(hdnPageSize.Value));
                divPager.Visible = true;
            }
            else
            {
                divPager.Visible = false;

            }
        }

        protected void GrdCategory_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="del")
            {
                balModel.Masters.Category.Delete(e.CommandArgument.ToString().ToIntFromString());
                BindGrid(0);
            }
        }
    }
}