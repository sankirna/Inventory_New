using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.DAL.PurchaseOrders;
using Inventory.Utility;
using Inventory.DAL.Supplier;
using Inventory.Utility;
using System.Globalization;
using System.Web.Script.Serialization;
using Inventory.DAL.PurchaseOrders;
using balmodel = Inventory.BAL;

namespace Inventory.Web.PurchaseOrder
{
    public partial class PurchaseOrderList : System.Web.UI.Page
    {
        balmodel.SupplierPurchaseOrder InvSupplierPurchaseOrder = new balmodel.SupplierPurchaseOrder();
        balmodel.PurchaseOrderItem objPurchaseOrderItemt = new balmodel.PurchaseOrderItem();
        SupplierDTO supplierLib = new SupplierDTO();

        PurchaseOrderLib purchaseOrderLib = new PurchaseOrderLib();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlSupplier.BindDropDown(supplierLib.GetListForDDL(), "SupplierName", "SupplierID");
                grdPOList.DataSource = purchaseOrderLib.GetListForDDL(0,"","","");
                grdPOList.DataBind();
            }
        }

        protected void btnPO_Click(object sender, EventArgs e)
        {
            Response.Redirect("PurchaseOrder.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            grdPOList.DataSource = purchaseOrderLib.GetListForDDL(ddlSupplier.SelectedValue.ToIntFromString(), txtPONo.Text, txtPODateTo.Text, txtPODateFrom.Text);
            grdPOList.DataBind();
        }
        void CheckMessage()
        {
            if (Request.QueryString["type"] != null)
            {
                if (Request.QueryString["type"] == "insert")
                {
                    if (Request.QueryString["msg"] == "suc")
                    {
                        Notification.ShowNotification(this.Page, "<b>Purchase Order :</b> PO added Successfully!!", NotifyMessge.success);

                    }
                    else if (Request.QueryString["msg"] == "err")
                    {
                        Notification.ShowNotification(this.Page, "<b>Purchase Order :</b> Something Went wrong", NotifyMessge.error);



                    }
                }
                else if (Request.QueryString["type"] == "Update")
                {
                    if (Request.QueryString["msg"] == "suc")
                    {
                        Notification.ShowNotification(this.Page, "<b>Purchase Order :</b> PO Updated Successfully!!", NotifyMessge.success);

                    }
                    else if (Request.QueryString["msg"] == "err")
                    {
                        Notification.ShowNotification(this.Page, "<b>Purchase Order :</b> Something Went wrong", NotifyMessge.error);



                    }
                }

            }

        }
    }
}