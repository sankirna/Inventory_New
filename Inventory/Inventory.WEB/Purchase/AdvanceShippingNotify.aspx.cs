using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inventory.BAL.AdvanceShippingNotify;
using Inventory.Utility;
using balModel = Inventory.BAL;
using Inventory.DAL.PurchaseOrders;
using Inventory.BAL.PurchaseOrdersBO;

namespace Inventory.Web.Purchase
{
    public partial class AdvanceShippingNotify : System.Web.UI.Page
    {
        PurchaseOrderLib purchaseOrderLib = new PurchaseOrderLib();
        AdvanceShippingNotifyLib _advanceShippingNotifyLib = new AdvanceShippingNotifyLib();
        private AdvanceShippingNotifyModels model = new AdvanceShippingNotifyModels();

        private List<AdvanceShippingProductDetailModel> advanceShippingProductDetailGirModels = new List<AdvanceShippingProductDetailModel>();

        private int _purchaseOrderId
        {
            get
            {
                return Request.QueryString["POID"].ToIntFromString();
            }
        }
        //ASNID
        private int _asnId
        {
            get
            {
                return Request.QueryString["ASNID"].ToIntFromString();
            }
        }

        #region MainGrid

        private AdvanceShippingProductDetailModel AddAdvanceShippingProductDetailModel(GridViewRow row)
        {

            //Find the control here.
            HiddenField hdASNID = (HiddenField)row.FindControl("hdASNID");
            HiddenField hdAsnProductDetailsId = (HiddenField)row.FindControl("hdAsnProductDetailsId");
            HiddenField hdPurchaseOrderDetailProductId = (HiddenField)row.FindControl("hdPurchaseOrderDetailProductId");
            HiddenField hdProductId = (HiddenField)row.FindControl("hdProductId");
            TextBox txtStartinNo = (TextBox)row.FindControl("txtStartinNo");
            TextBox txtEndNo = (TextBox)row.FindControl("txtEndNo");
            Label lblItemCode = (Label)row.FindControl("lblItemCode");
            Label lblDescription = (Label)row.FindControl("lblDescription");
            Label lblBarCode = (Label)row.FindControl("lblBarCode");
            TextBox lblPurchaseCost = (TextBox)row.FindControl("lblPurchaseCost");
            TextBox txtQty = (TextBox)row.FindControl("txtQty");
            TextBox txtAmount = (TextBox)row.FindControl("txtAmount");
            DropDownList ddlCountry = (DropDownList)row.FindControl("ddlCountry");
            TextBox txtSize = (TextBox)row.FindControl("txtSize");
            TextBox txtGrossWeight = (TextBox)row.FindControl("txtGrossWeight");
            TextBox txtNetWeight = (TextBox)row.FindControl("txtNetWeight");
            TextBox txtNofofCartons = (TextBox)row.FindControl("txtNofofCartons");
            TextBox txtWeightperCarton = (TextBox)row.FindControl("txtWeightperCarton");
            TextBox txtQtyperCarton = (TextBox)row.FindControl("txtQtyperCarton");
            TextBox txtMFDate = (TextBox)row.FindControl("txtMFDate");


            AdvanceShippingProductDetailModel advanceShippingProductDetailModel = new AdvanceShippingProductDetailModel();
            advanceShippingProductDetailModel.ASNID = hdASNID.Value.ToIntFromString();
            advanceShippingProductDetailModel.AsnProductDetailsId = hdAsnProductDetailsId.Value.ToIntFromString();
            advanceShippingProductDetailModel.PurchaseOrderDetailProductId = hdPurchaseOrderDetailProductId.Value.ToIntFromString();
            advanceShippingProductDetailModel.ProductId = hdProductId.Value.ToIntFromString();
            advanceShippingProductDetailModel.CartonStartingNo = txtStartinNo.Text.ToIntFromString();
            advanceShippingProductDetailModel.CartonEndingNo = txtEndNo.Text.ToIntFromString();
            advanceShippingProductDetailModel.ItemCode = lblItemCode.Text;
            advanceShippingProductDetailModel.Description = lblDescription.Text;
            advanceShippingProductDetailModel.BarCode = lblBarCode.Text;
            advanceShippingProductDetailModel.UnitPrice = lblPurchaseCost.Text.ToDecimalFromString();
            advanceShippingProductDetailModel.Quantity = txtQty.Text.ToIntFromString();
            advanceShippingProductDetailModel.Amount = txtAmount.Text.ToDecimalFromString();
            advanceShippingProductDetailModel.CountryId = ddlCountry.SelectedValue.ToIntFromString();
            advanceShippingProductDetailModel.SizeMM = txtSize.Text;
            advanceShippingProductDetailModel.GWKG = txtGrossWeight.Text;
            advanceShippingProductDetailModel.NWKG = txtNetWeight.Text;
            advanceShippingProductDetailModel.NoofCartons = txtNofofCartons.Text.ToIntFromString();
            advanceShippingProductDetailModel.WeightCarton = txtWeightperCarton.Text;
            advanceShippingProductDetailModel.QuantityCarton = txtQtyperCarton.Text.ToIntFromString();
            advanceShippingProductDetailModel.MFDate = txtMFDate.Text;

            // purchaseOrderItemModel.Products
            return advanceShippingProductDetailModel;
        }

        public void LoadControls()
        {
            List<CurrencyModel> currencyModels = _advanceShippingNotifyLib.GetCurrencyMasters();

            ddlCountryTo.BindDropDown(currencyModels, "CurrencyName", "CurrencyId");
            ddlCountryFrom.BindDropDown(currencyModels, "CurrencyName", "CurrencyId");
            drpProduct.BindDropDown(purchaseOrderLib.GetProdutPruchaseOrder(), "Code", "ProductID");
            drpProduct.Items.RemoveAt(0);

            model = _advanceShippingNotifyLib.GetAdvanceShippingNotify(_purchaseOrderId,_asnId);

            hdnSupplierId.Value = model.SupplierID.ToStringFromInt();
            txtSupplier.Text = model.SupplierName;
            hdPoId.Value = model.PurchaseOrderID.ToStringFromInt();
            txtPONo.Text = model.PONumber;
            txtPODate.Text = model.PODate;

            txtETD.Text = model.ETA;
            txtPINo.Text = model.PINo;
            txtInvoiceNo.Text = model.InvoiceNo;
            ddlCountryFrom.SelectedValue = model.FromCountry.ToStringFromInt();
            ddlCountryTo.SelectedValue = model.ToCountry.ToStringFromInt();
            ddlShippingMethod.SelectedValue = model.ShippingMethod;
            txtTotalM3.Text = model.TotalM3.ToStringFromObject();

            grdPackingList.DataSource = model.AdvanceShippingProductDetails.Where(x=>x.PurchaseOrderDetailProductId!=0);
            grdPackingList.DataBind();


            grdGiftList.DataSource = model.AdvanceShippingProductDetails.Where(x => x.PurchaseOrderDetailProductId == 0);
            grdGiftList.DataBind();
        }

        public void SetModel()
        {
            model.ASNID = _asnId;
            model.SupplierID = hdnSupplierId.Value.ToIntFromString();
            model.SupplierName = txtSupplier.Text;
            model.PurchaseOrderID = hdPoId.Value.ToIntFromString();
            model.PONumber = txtPONo.Text;
            model.PODate = txtPODate.Text;

            model.ETA = txtETD.Text;
            model.PINo = txtPINo.Text;
            model.InvoiceNo = txtInvoiceNo.Text;
            model.FromCountry = ddlCountryFrom.SelectedValue.ToIntFromString();
            model.ToCountry = ddlCountryTo.SelectedValue.ToIntFromString();
            model.ShippingMethod = ddlShippingMethod.SelectedValue;
            model.TotalM3 = txtTotalM3.Text.ToDecimalFromString();

            foreach (GridViewRow row in grdPackingList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    model.AdvanceShippingProductDetails.Add(AddAdvanceShippingProductDetailModel(row));
                }
            }
            foreach (GridViewRow row in grdGiftList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    model.AdvanceShippingProductDetails.Add(AddAdvanceShippingProductDetailModel(row));
                }
            }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LoadControls();
                //pnlEdit.Visible = _asnId <= 0;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SetModel();
            string result = _advanceShippingNotifyLib.AddUpdateAdvanceShipping(model);
            if (result.Contains("Error"))
            {
                lblError.Text = result;
            }
            else
            {
                Response.Redirect("~/Purchase/AdvanceShippingList.aspx");
            }
        }

        protected void btnAddGift_click(object sender, EventArgs e)
        {
            List<CurrencyModel> currencyModels = _advanceShippingNotifyLib.GetCurrencyMasters();
            foreach (GridViewRow row in grdGiftList.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    advanceShippingProductDetailGirModels.Add(AddAdvanceShippingProductDetailModel(row));
                }
            }

            ProductPurchaseOrderModel productPurchaseOrderModel =purchaseOrderLib.GetProductDetailbyId(drpProduct.SelectedValue.ToIntFromString());

            // Set Add Model
            AdvanceShippingProductDetailModel  advanceShippingProductDetailModel=new AdvanceShippingProductDetailModel();
            advanceShippingProductDetailModel.ProductId = productPurchaseOrderModel.ProductID;
            advanceShippingProductDetailModel.ItemCode = productPurchaseOrderModel.Code;
            advanceShippingProductDetailModel.BarCode = productPurchaseOrderModel.BarCode;
            advanceShippingProductDetailModel.Description = productPurchaseOrderModel.Description;
            advanceShippingProductDetailModel.UnitPrice = productPurchaseOrderModel.Cost.ToNullDecimal();
            advanceShippingProductDetailModel.Quantity = productPurchaseOrderModel.QtyPerCarton;
            advanceShippingProductDetailModel.Amount = advanceShippingProductDetailModel.UnitPrice*
                                                       advanceShippingProductDetailModel.Quantity;

            advanceShippingProductDetailGirModels.Add(advanceShippingProductDetailModel);
            advanceShippingProductDetailGirModels.ForEach(x => x.CurrencyModels = currencyModels);
            grdGiftList.DataSource = advanceShippingProductDetailGirModels;
            grdGiftList.DataBind();
        }

    }
}