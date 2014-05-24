using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Utility;
using objbal = Inventory.BAL;
using objdal = Inventory.DAL;

namespace Inventory.Web
{
    public partial class BrandList : System.Web.UI.Page
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
                CheckMessage();
            }
        }
        void Pager_OnPageIndexChanging(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            hdnCurrentPageIndex.Value = index.ToString();

            BindGrid(index);
        }
        void CheckMessage()
        {
            if (Request.QueryString["type"] != null)
            {
                if (Request.QueryString["type"] == "insert")
                {
                    if (Request.QueryString["msg"] == "suc")
                    {
                        Notification.ShowNotification(this.Page, "<b>Brand :</b> Brand added Successfully!!", NotifyMessge.success);

                    }
                    else if (Request.QueryString["msg"] == "err")
                    {
                        Notification.ShowNotification(this.Page, "<b>Brand :</b> Something Went wrong", NotifyMessge.error);



                    }
                }
                else if (Request.QueryString["type"] == "Update")
                {
                    if (Request.QueryString["msg"] == "suc")
                    {
                        Notification.ShowNotification(this.Page, "<b>Brand :</b> Brand Updated Successfully!!", NotifyMessge.success);

                    }
                    else if (Request.QueryString["msg"] == "err")
                    {
                        Notification.ShowNotification(this.Page, "<b>Brand :</b> Something Went wrong", NotifyMessge.error);



                    }
                }

            }

        }
        protected void BindGrid(int PageIndex)
        {

            List<objdal.BrandMaster> lstProductDTO = objbal.Masters.Brand.GetBrandList( PageIndex, Convert.ToInt32(hdnPageSize.Value));
            if (lstProductDTO != null && lstProductDTO.Count > 0)
            {
                int totalrecords = objbal.Masters.Brand.GetBrandCount();
                hdnTotalRecords.Value = totalrecords.ToString();
                lblNoRecords.Text = "Total Records : " + hdnTotalRecords.Value;
                GrdBrand.PageSize = Convert.ToInt32(hdnPageSize.Value);
                GrdBrand.DataSource = lstProductDTO;
                GrdBrand.DataBind();
                GrdBrand.PageIndex = Convert.ToInt32(hdnCurrentPageIndex.Value);
                GrdBrand.PagerSettings.PageButtonCount = Convert.ToInt32(hdnPageButtonCount.Value);
                int totalpages = totalrecords / Convert.ToInt32(hdnPageSize.Value);
                if (totalrecords % Convert.ToInt32(hdnPageSize.Value.ToString()) > 0)
                {
                    totalrecords += 1;
                }
                if (totalrecords < 1)
                    CurrentPageNo.Text = "Page : 0/0";
                else
                    CurrentPageNo.Text = "Page : " + (GrdBrand.PageIndex + 1).ToString(System.Globalization.CultureInfo.InstalledUICulture) + "/" + totalpages.ToString(System.Globalization.CultureInfo.InstalledUICulture);
                //Recreating the pager as per page index
                Pager.LoadPager(Convert.ToInt32(hdnCurrentPageIndex.Value), totalrecords, Convert.ToInt32(hdnPageSize.Value));
                divPager.Visible = true;
            }
            else
            {

            }


        }
    }
}