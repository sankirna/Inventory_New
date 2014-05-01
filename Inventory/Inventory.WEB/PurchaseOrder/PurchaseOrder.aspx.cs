using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.BAL.PurchaseOrdersBO;
using Inventory.Utility;
using Inventory.DAL.Supplier;
using Inventory.Utility;
using System.Globalization;
using System.Web.Script.Serialization;
using objbal = Inventory.BAL;

namespace Inventory.Web.PurchaseOrder
{
    public partial class PurchaseOrder : System.Web.UI.Page
    {

        PurchaseOrderLib purchaseOrderLib = new PurchaseOrderLib();
        SupplierDTO supplierLib = new SupplierDTO();
        JavaScriptSerializer serializer = new JavaScriptSerializer();

        private List<PurchaseOrderItemModel> SetListItemModel()
        {
            List<PurchaseOrderItemModel> purchaseOrderItems = new List<PurchaseOrderItemModel>();

            foreach (GridViewRow row in grdPurchaseOrder.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    purchaseOrderItems.Add(AddProductItemModel(row));
                }
            }

            return purchaseOrderItems;
        }

        private PurchaseOrderItemModel AddProductItemModel(GridViewRow row)
        {
            PurchaseOrderItemModel purchaseOrderItemModel = new PurchaseOrderItemModel();

            //Find the control here.
            HiddenField hdPurchaseOrderDetailID = (HiddenField)row.FindControl("hdPurchaseOrderDetailID");
            HiddenField hdPurchaseOrderID = (HiddenField)row.FindControl("hdPurchaseOrderID");
            TextBox txtQty = (TextBox)row.FindControl("txtQty");
            TextBox txtCost = (TextBox)row.FindControl("txtCost");
            TextBox txtAmount = (TextBox)row.FindControl("txtAmount");
            DropDownList drpItemCode = (DropDownList)row.FindControl("drpItemCode");

            purchaseOrderItemModel.PurchaseOrderDetailID = hdPurchaseOrderDetailID.Value.ToIntFromString();
            purchaseOrderItemModel.PurchaseOrderID = hdPurchaseOrderID.Value.ToIntFromString();
            purchaseOrderItemModel.Quantity = txtQty.Text.ToIntFromString();
            purchaseOrderItemModel.Cost = txtCost.Text.ToDecimalFromString();
            purchaseOrderItemModel.Amount = txtAmount.Text.ToDecimalFromString();
            purchaseOrderItemModel.ProductID = drpItemCode.SelectedValue.ToIntFromString();

            foreach (ListItem item in drpItemCode.Items)
            {
                purchaseOrderItemModel.Products.Add(new ProductPurchaseOrderModel() { ProductID = item.Value.ToIntFromString(), Code = item.Text });
            }

            // purchaseOrderItemModel.Products
            return purchaseOrderItemModel;
        }

        private List<PurchaseOrderItemModel> AddNewItem(List<PurchaseOrderItemModel> purchaseOrderItemModels)
        {

            PurchaseOrderItemModel purchaseOrderItemModel = new PurchaseOrderItemModel();
            purchaseOrderItemModel.Products = purchaseOrderItemModels.FirstOrDefault().Products;
            purchaseOrderItemModels.Add(purchaseOrderItemModel);
            return purchaseOrderItemModels;
        }

        private PurchaseOrderModel SetPurchaseOrderModel()
        {
            PurchaseOrderModel purchaseOrderModel = new PurchaseOrderModel();
            if (Request.QueryString["POID"] != null)
            {
                purchaseOrderModel.PurchaseOrderID = Request.QueryString["POID"].ToIntFromString();
            }
            purchaseOrderModel.SupplierID = ddSupplier.SelectedValue.ToIntFromString();
            purchaseOrderModel.PODate = Convert.ToDateTime(txtPODate.Text.Trim());
            purchaseOrderModel.PurchaseOrderItems = SetListItemModel();
            purchaseOrderModel.TermCondition = txtTermcondition.Text;
            return purchaseOrderModel;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtTermcondition.Text = System.Configuration.ConfigurationManager.AppSettings["TERMCONDITION"].ToStringFromObject();
                PurchaseOrderModel PurchaseOrderModel = objbal.PurchaseOrdersBO.PurchaseOrdersBO.GetPurchaseOrder (Request.QueryString["POID"] == null ? 0 : Request.QueryString["POID"].ToString().ToIntFromString());
                ddSupplier.BindDropDown(supplierLib.GetListForDDL(), "SupplierName", "SupplierID");
                if (Request.QueryString["POID"] != null)
                {
                    ddSupplier.SelectedValue = PurchaseOrderModel.SupplierID.ToStringFromInt();
                    txtPODate.Text = PurchaseOrderModel.PODate.GetForamttedDate();
                    txtTermcondition.Text = PurchaseOrderModel.TermCondition;
                }
                grdPurchaseOrder.DataSource = PurchaseOrderModel.PurchaseOrderItems;
                grdPurchaseOrder.DataBind();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "purchseItem", "jsonpurchseItemobject=" + serializer.Serialize(PurchaseOrderModel.PurchaseOrderItems.FirstOrDefault().Products), true);
            }
        }

        protected void btnPOAdd_Click(object sender, EventArgs e)
        {
            List<PurchaseOrderItemModel> purchaseOrderItems = AddNewItem(SetListItemModel());
            grdPurchaseOrder.DataSource = purchaseOrderItems;
            grdPurchaseOrder.DataBind();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "purchseItem", "jsonpurchseItemobject=" + serializer.Serialize(purchaseOrderLib.GetProdutPruchaseOrder()), true);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string  result = purchaseOrderLib.AddUpdatePurchaseOrder(SetPurchaseOrderModel());
            if (result=="Insert")
            {
                Response.Redirect("~/PurchaseOrder/PurchaseOrderlist.aspx?msg=suc&type=insert");
            }
            else if (result == "update")
            {
                Response.Redirect("~/PurchaseOrder/PurchaseOrderlist.aspx?msg=suc&type=Update");
            }
            else
            {
                Response.Redirect("~/PurchaseOrder/PurchaseOrderlist.aspx?msg=err&type=insert");
            }
         
        }
    }
}