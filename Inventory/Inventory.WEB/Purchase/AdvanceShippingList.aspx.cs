using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.BAL.AdvanceShippingNotify;
using Inventory.DAL.Supplier;
using Inventory.Utility;
using modelbal = Inventory.BAL;

namespace Inventory.Web.Purchase
{
    
    public partial class AdvanceShippingList : System.Web.UI.Page
    {
        AdvanceShippingLib _advanceShippingLib = new AdvanceShippingLib();
        SupplierDTO _supplierLib = new SupplierDTO();

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

                ddlSupplier.BindDropDown(_supplierLib.GetListForDDL(), "SupplierName", "SupplierID");
                BindGrid(true, 0, "", "", "", 0);
            }
        }

        private void Pager_OnPageIndexChanging(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(((LinkButton)sender).CommandArgument);
            hdnCurrentPageIndex.Value = index.ToString();


            BindGrid(false, ddlSupplier.SelectedValue.ToIntFromString(), txtPONo.Text, txtPODateFrom.Text, txtPODateTo.Text, index);
        }

        protected void btnPO_Click(object sender, EventArgs e)
        {
            Response.Redirect("PurchaseOrder.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrid(false, ddlSupplier.SelectedValue.ToIntFromString(), txtPONo.Text, txtPODateFrom.Text, txtPODateTo.Text, 0);
        }

        void BindGrid(bool onPageload, int supplierId, string pONumber, string fromDate, string tODate, int pageIndex)
        {
            List<AdvanceShippingModel> lstAdvList = _advanceShippingLib.GetList(supplierId,
                pONumber, fromDate, tODate, onPageload, pageIndex, hdnPageSize.Value.ToIntFromString());
            if (lstAdvList != null && lstAdvList.Count > 0)
            {
                int totalrecords = BAL.PurchaseOrdersBO.PurchaseOrdersBO.GetPoCount(supplierId, pONumber, fromDate,
                    tODate, onPageload);
                hdnTotalRecords.Value = totalrecords.ToString();
                lblNoRecords.Text = "Total Records : " + hdnTotalRecords.Value;
                grdAdvanceShipp.PageSize = Convert.ToInt32(hdnPageSize.Value);
                grdAdvanceShipp.DataSource = lstAdvList;
                grdAdvanceShipp.DataBind();
                grdAdvanceShipp.PageIndex = Convert.ToInt32(hdnCurrentPageIndex.Value);
                grdAdvanceShipp.PagerSettings.PageButtonCount = Convert.ToInt32(hdnPageButtonCount.Value);
                int totalpages = totalrecords / Convert.ToInt32(hdnPageSize.Value);
                if (totalrecords % Convert.ToInt32(hdnPageSize.Value.ToString()) > 0)
                {
                    totalrecords += 1;
                }
                if (totalrecords < 1)
                    CurrentPageNo.Text = "Page : 0/0";
                else
                    CurrentPageNo.Text = "Page : " + (grdAdvanceShipp.PageIndex + 1).ToString(System.Globalization.CultureInfo.InstalledUICulture) + "/" + totalpages.ToString(System.Globalization.CultureInfo.InstalledUICulture);
                //Recreating the pager as per page index
                Pager.LoadPager(Convert.ToInt32(hdnCurrentPageIndex.Value), totalrecords, Convert.ToInt32(hdnPageSize.Value));
                divPager.Visible = true;
            }
            else
            {
                divPager.Visible = false;

            }


        }
    }
}