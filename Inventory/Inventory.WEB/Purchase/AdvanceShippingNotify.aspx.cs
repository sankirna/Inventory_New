using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.BAL.AdvanceShippingNotify;
using Inventory.BAL.PurchaseOrdersBO;
using Inventory.Utility;
using balModel = Inventory.BAL;

namespace Inventory.Web.Purchase
{
    public partial class AdvanceShippingNotify : System.Web.UI.Page
    {

        AdvanceShippingNotifyLib advanceShippingNotifyLib = new AdvanceShippingNotifyLib();
        JavaScriptSerializer serializer = new JavaScriptSerializer();

        private int _purchaseOrderId
        {
            get
            {
                return Request.QueryString["POID"].ToIntFromString();
            }
        }



        private AdvanceShippingProductDetailModel AddAdvanceShippingProductDetailModel(GridViewRow row)
        {
            AdvanceShippingProductDetailModel advanceShippingProductDetailModel = new AdvanceShippingProductDetailModel();

            //Find the control here.
            HiddenField hdASNProductDetailsID = (HiddenField)row.FindControl("hdASNProductDetailsID");
            HiddenField hdASNID = (HiddenField)row.FindControl("hdASNID");
            TextBox txtQty = (TextBox)row.FindControl("txtQty");
            TextBox txtCost = (TextBox)row.FindControl("txtCost");
            TextBox txtAmount = (TextBox)row.FindControl("txtAmount");
            TextBox txtQtyperCarton = (TextBox)row.FindControl("txtQtyperCarton");
            TextBox txtMFDate = (TextBox)row.FindControl("txtMFDate");
            DropDownList drpItemCode = (DropDownList)row.FindControl("drpItemCode");

            advanceShippingProductDetailModel.ASNProductDetailsID = hdASNProductDetailsID.Value.ToIntFromString();
            advanceShippingProductDetailModel.ASNID = hdASNID.Value.ToIntFromString();
            advanceShippingProductDetailModel.Qty = txtQty.Text.ToIntFromString();
            advanceShippingProductDetailModel.UnitPrice = txtCost.Text.ToDecimalFromString();
            advanceShippingProductDetailModel.Rate = txtAmount.Text.ToDecimalFromString();
            advanceShippingProductDetailModel.MFDate = txtMFDate.Text;
            advanceShippingProductDetailModel.ProductID = drpItemCode.SelectedValue.ToIntFromString();
            foreach (ListItem item in drpItemCode.Items)
            {
                advanceShippingProductDetailModel.Products.Add(new ProductAdvanceShipping() { ProductID = item.Value.ToIntFromString(), Code = item.Text });
            }

            // purchaseOrderItemModel.Products
            return advanceShippingProductDetailModel;
        }

        private List<AdvanceShippingProductDetailModel> SetListItemModel()
        {
            List<AdvanceShippingProductDetailModel> advanceShippingProductDetailModel = new List<AdvanceShippingProductDetailModel>();

            foreach (GridViewRow row in grdPackingList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    advanceShippingProductDetailModel.Add(AddAdvanceShippingProductDetailModel(row));
                }
            }

            return advanceShippingProductDetailModel;
        }

        private AdvanceShippingNotifyModels SetadvanceShippingNotifyModel()
        {
            AdvanceShippingNotifyModels advanceShippingNotifyModels = new AdvanceShippingNotifyModels();
            advanceShippingNotifyModels.PurchaseOrderID = _purchaseOrderId;
            advanceShippingNotifyModels.SupplierID = hdSupplierId.Value.ToIntFromString();
            advanceShippingNotifyModels.DateOfShipment = txtCountryFrom.Text.GetStringToFormatedDate();
            advanceShippingNotifyModels.AdvanceShippingProductDetails = SetListItemModel();
            return advanceShippingNotifyModels;
        }



        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                AdvanceShippingNotifyModels AdvanceShippingNotifyModels = advanceShippingNotifyLib.GetAdvanceShippingNotify(_purchaseOrderId);
                hdSupplierId.Value = AdvanceShippingNotifyModels.SupplierID.ToStringFromObject();
                txtCountryFrom.Text = AdvanceShippingNotifyModels.DateOfShipment.ToStringFromObject();
                txtSupplier.Text = AdvanceShippingNotifyModels.SupplierName;
                txtPODate.Text = AdvanceShippingNotifyModels.PODate;
                txtPONo.Text = AdvanceShippingNotifyModels.PONumber;
                grdPackingList.DataSource = AdvanceShippingNotifyModels.AdvanceShippingProductDetails;
                grdPackingList.DataBind();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "purchseItem", "jsonpurchseItemobject=" + serializer.Serialize(AdvanceShippingNotifyModels.AdvanceShippingProductDetails.FirstOrDefault().Products), true);

            }
        }



        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string result = advanceShippingNotifyLib.AddUpdateAdvanceShipping(SetadvanceShippingNotifyModel());
        }



    }
}