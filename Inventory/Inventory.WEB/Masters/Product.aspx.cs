using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using objProduct = Inventory.BAL;
using objDAl = Inventory.DAL;
using Inventory.Utility;

namespace Inventory.Web
{
    public partial class Product : System.Web.UI.Page
    {
        //balModel.SupplierBrand supplier = new balModel.SupplierBrand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownUtility.BindDropDown(drpSupplier, objProduct.SupplierBrand.GetListForDDL(), "SupplierName", "SupplierID");
                DropDownUtility.BindDropDown(drpUOM, objProduct.UOMaster.GetDataForDropdown(), "UomName", "UOMID");
                DropDownUtility.BindDropDown(drpCurncy, objProduct.Country.GetList(), "CountryName", "CountryID");
                DropDownUtility.BindDropDown(drpCurncy, objProduct.Currency.GetList(), "CurrencyName", "CurrencyID");
                int productId = 0;
                if (Request.QueryString["id"] != null)
                {
                    productId = Convert.ToInt32(Request.QueryString["id"]);
                    BindData(productId);
                }
                
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
           
            if (IsValid)
            {
                objDAl.ProductMaster product = new objDAl.ProductMaster();
                product.ItemCode = txtItemCode.Text;
                product.Description = txtDesc.Text;
                product.MFBarcode = txtMFBarcode.Text;
                product.SupplierID = Convert.ToInt32(drpSupplier.SelectedValue);
                product.UOMID = Convert.ToInt32(drpUOM.SelectedValue);
                product.DiLength = txtDimenLgth.Text;
                product.DiBreadth = txtBreadth.Text;
                product.DiHeight = txtHeight.Text;
                product.DiWeight = txtWeight.Text;
                product.SpLength = txtStdPackSize.Text;
                product.SpBreadth = txtStdBreadth.Text;
                product.SpHeight = txtStdHeight.Text;
                product.SpWeight = txtStdWeight.Text;
                product.QPC = Convert.ToInt32(txtQtyperCartoon.Text);
                product.BasicPC = Convert.ToDecimal(txtPurchCost.Text);
                product.CurrencyID = Convert.ToInt32(drpCurncy.SelectedValue);
                product.SRP = Convert.ToDecimal(txtRetailPrice.Text);
                product.ShelfLife = Convert.ToInt32(txtShelfLife.Text);
                
              //  product.DateModified = System.DateTime.Now;
               // product.ModifiedBy = 1;
                //product.Status = 
                if (btnSave.Text == "Submit")
                {
                    product.CreatedBy = 1;
                    product.DateCreated = System.DateTime.Now;
                    product.Status = 1;
                 string objResult=   objProduct.Product.Insert(product);
                 if (objResult=="suc")
                 {
                     Response.Redirect("ProductList.aspx?msg=suc&type=insert");
                 }
                 else
                 {
                     Response.Redirect("ProductList.aspx?msg=err&type=insert");
                 }

                }
                else
                {
                    product.ModifiedBy = 1;
                    product.DateModified = System.DateTime.Now;
                    product.ProductID = Convert.ToInt32(Request.QueryString["id"]);
                  string objResult = objProduct.Product.Update(product);
                  if (objResult == "suc")
                  {
                      Response.Redirect("ProductList.aspx?msg=suc&type=Update");
                  }
                  else
                  {
                      Response.Redirect("ProductList.aspx?msg=err&type=Update");
                  }
                }
               
            }
        }

        public void BindData(int id)
        {
            try
            {
                objDAl.ProductMaster product = objProduct.Product.GetProductById(id);
                txtBreadth.Text = product.DiBreadth;
                txtDesc.Text = product.Description;
                txtDimenLgth.Text = product.DiLength;
                txtHeight.Text = product.DiHeight;
                txtItemCode.Text = product.ItemCode;
                txtMFBarcode.Text = product.MFBarcode;
                txtPurchCost.Text = Convert.ToString(product.BasicPC);
                txtQtyperCartoon.Text = Convert.ToString(product.QPC);
                txtRetailPrice.Text = Convert.ToString(product.SRP);
                txtShelfLife.Text = Convert.ToString(product.ShelfLife);
                txtStdBreadth.Text = product.SpBreadth;
                txtStdHeight.Text = product.SpHeight;
                txtStdPackSize.Text = product.SpLength;
                txtStdWeight.Text = product.SpWeight;
                txtWeight.Text = product.DiWeight;
                drpCurncy.SelectedValue = Convert.ToString(product.CurrencyID);
                drpSupplier.SelectedValue = Convert.ToString(product.SupplierID);
                drpUOM.SelectedValue = Convert.ToString(product.UOMID);
                btnSave.Text = "Update";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}