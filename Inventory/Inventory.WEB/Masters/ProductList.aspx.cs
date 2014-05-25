using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.Utility;
using objBal = Inventory.BAL;
using objDal = Inventory.DAL;


namespace Inventory.Web
{
    public partial class ProductList : System.Web.UI.Page
    {
        objBal.Product objProductcls = new objBal.Product();
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
                DropDownUtility.BindDropDown(drpSupplier, objBal.SupplierBrand.GetListForDDL(), "SupplierName", "SupplierID");
                hdnTotalRecords.Value = string.Empty;
                hdnCurrentPageIndex.Value = "0";
                hdnSupplierID.Value = "0";
              //  GrdProduct.DataSource = product.GetProductList();
               // GrdProduct.DataBind();
                BindGrid(0, true,0);
                CheckMessage();
            }

        }
        void CheckMessage()
        {
            if (Request.QueryString["type"]!=null)
            {
                if (Request.QueryString["type"]=="insert")
	{
		  if (Request.QueryString["msg"]=="suc")
                {
                    Notification.ShowNotification(this.Page, "<b>Product :</b> Product added Successfully!!", NotifyMessge.success);
                    
                }
                else if (Request.QueryString["msg"] == "err")
                {
                    Notification.ShowNotification(this.Page, "<b>Product :</b> Something Went wrong", NotifyMessge.error);

                    

                }
	}
                else if (Request.QueryString["type"] == "Update")
                {
                    if (Request.QueryString["msg"] == "suc")
                    {
                        Notification.ShowNotification(this.Page, "<b>Product :</b> Product Updated Successfully!!", NotifyMessge.success);

                    }
                    else if (Request.QueryString["msg"] == "err")
                    {
                        Notification.ShowNotification(this.Page, "<b>Product :</b> Something Went wrong", NotifyMessge.error);



                    }
                }
               
            }
           
        }
        void Pager_OnPageIndexChanging(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            hdnCurrentPageIndex.Value = index.ToString();
            
            BindGrid(index, false,Convert.ToInt32(hdnSupplierID.Value));
        }

        protected void btnProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("Product.aspx");
        } 
        protected void BindGrid(int PageIndex,bool isOnPageLoad,int SupplierId)
        {
           
            List<objDal.ProductMaster> lstProductDTO = objBal.Product.GetProductList(isOnPageLoad, PageIndex, Convert.ToInt32(hdnPageSize.Value), SupplierId);
            if (lstProductDTO != null && lstProductDTO.Count>0)
            {
                int totalrecords = objBal.Product.GetProductCount(isOnPageLoad,SupplierId);
                hdnTotalRecords.Value = totalrecords.ToString();
                lblNoRecords.Text = "Total Records : " + hdnTotalRecords.Value;
                grdProduct.PageSize = Convert.ToInt32(hdnPageSize.Value);
                grdProduct.DataSource = lstProductDTO;
                grdProduct.DataBind();
                grdProduct.PageIndex = Convert.ToInt32(hdnCurrentPageIndex.Value);
                grdProduct.PagerSettings.PageButtonCount = Convert.ToInt32(hdnPageButtonCount.Value);
                int totalpages = totalrecords / Convert.ToInt32( hdnPageSize.Value);
                if (totalrecords % Convert.ToInt32(hdnPageSize.Value.ToString()) >0)
                {
                    totalrecords += 1;
                }
                if (totalrecords < 1)
                    CurrentPageNo.Text = "Page : 0/0";
                else
                    CurrentPageNo.Text = "Page : " + (grdProduct.PageIndex + 1).ToString(System.Globalization.CultureInfo.InstalledUICulture) + "/" + totalpages.ToString(System.Globalization.CultureInfo.InstalledUICulture);
                //Recreating the pager as per page index
                Pager.LoadPager(Convert.ToInt32(hdnCurrentPageIndex.Value), totalrecords, Convert.ToInt32(hdnPageSize.Value));
                divPager.Visible = true;
            }
            else
            {
                divPager.Visible = false;

            }
            

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            hdnSupplierID.Value = drpSupplier.SelectedValue;
            BindGrid(0, false, Convert.ToInt32(drpSupplier.SelectedValue));
        }

        protected void grdProduct_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="del")
            {
                string objResult = objBal.Product.Delete(Convert.ToInt32(e.CommandArgument));
                if (objResult=="suc")
                {
                    Notification.ShowNotification(this, "<b>Product : </b>Product Deleted Successfully!!", NotifyMessge.success);
                }
                else
                {
                    Notification.ShowNotification(this, "<b>Product : </b>Something Got wrong please try again!!", NotifyMessge.error);

                }
                BindGrid(Convert.ToInt32(hdnCurrentPageIndex.Value),false, Convert.ToInt32(hdnSupplierID.Value));
            }
        }
    }
}