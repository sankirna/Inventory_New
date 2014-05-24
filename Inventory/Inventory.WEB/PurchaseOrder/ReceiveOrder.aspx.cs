using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balmodel = Inventory.BAL;
using Inventory.Utility;

namespace Inventory.Web.PurchaseOrder
{
    public partial class ReceiveOrder : System.Web.UI.Page
    {
        balmodel.SupplierBrand supplierBrand = new balmodel.SupplierBrand();
        balmodel.AdvanceShippingNotification advanceShippingNotification = new balmodel.AdvanceShippingNotification();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable newProductdetailstable = CreateEmptyRow();
            //    grdReceiveDetails.DataSource = newProductdetailstable;
             //   grdReceiveDetails.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
        }
        private DataTable CreateEmptyRow()
        {
            int newID = 0;
            DataTable PackingList;
            try
            {


                PackingList = new DataTable();
                newID = 0;
                PackingList.Columns.Add("UniqueNo", typeof(int));
                PackingList.Columns.Add("ItemCode", typeof(string));
                PackingList.Columns.Add("Description", typeof(string));
                PackingList.Columns.Add("BarCode", typeof(string));
                PackingList.Columns.Add("UnitPrice", typeof(decimal));
                PackingList.Columns.Add("Quantity", typeof(decimal));
                PackingList.Columns.Add("Amount", typeof(decimal));
                PackingList.Columns.Add("NoofCartons", typeof(int));
                PackingList.Columns.Add("QtyinCarton", typeof(int));
                PackingList.Columns.Add("MFDate", typeof(string));

                
                    DataRow PRow1= PackingList.NewRow();
                    PRow1["UniqueNo"] = newID++;
                    PRow1["ItemCode"] = "FDM067";
                    PRow1["Description"] = "SHILLS Miracle Body Contour Control EX+hot 157%";
                    PRow1["BarCode"] = "3490725081";
                    PRow1["UnitPrice"] = 84;
                    PRow1["Quantity"] = 504;
                    PRow1["Amount"] = 42336;
                    PRow1["NoofCartons"] = 7;
                    PRow1["QtyinCarton"] = 72;
                    PRow1["MFDate"] = "01-Jan-2014";
                    PackingList.Rows.Add(PRow1);

                    DataRow PRow2 = PackingList.NewRow();
                    PRow2["UniqueNo"] = newID++;
                    PRow2["ItemCode"] = "SH1699126M067";
                    PRow2["Description"] = "SHILLS Whitening Pore-Refining Gel";
                    PRow2["BarCode"] = "3490725084";
                    PRow2["UnitPrice"] = 119.50;
                    PRow2["Quantity"] = 50;
                    PRow2["Amount"] = 5975;
                    PRow2["NoofCartons"] = 1;
                    PRow2["QtyinCarton"] = 50;
                    PRow2["MFDate"] = "01-Jan-2014";
                    PackingList.Rows.Add(PRow2);

                    DataRow PRow3 = PackingList.NewRow();
                    PRow3["UniqueNo"] = newID++;
                    PRow3["ItemCode"] = "SH1699126M069";
                    PRow3["Description"] = "SHILLS Rose Firming Eyce Cream";
                    PRow3["BarCode"] = "3490725085";
                    PRow3["UnitPrice"] = 120;
                    PRow3["Quantity"] = 50;
                    PRow3["Amount"] = 6000;
                    PRow3["NoofCartons"] = 1;
                    PRow3["QtyinCarton"] = 50;
                    PRow3["MFDate"] = "01-Jan-2014";
                    PackingList.Rows.Add(PRow3);
                


                return PackingList;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        protected void btnCRO_Click(object sender, EventArgs e)
        {

        }
    }
}