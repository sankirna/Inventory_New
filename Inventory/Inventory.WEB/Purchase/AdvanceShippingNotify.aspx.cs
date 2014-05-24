using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using balModel = Inventory.BAL;

namespace Inventory.Web.Purchase
{
    public partial class AdvanceShippingNotify : System.Web.UI.Page
    {
        balModel.PurchaseSupplierOrder purchaseSupplierOrder = new balModel.PurchaseSupplierOrder();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                DataTable newProductdetailstable = CreateEmptyRow();
                grdPackingList.DataSource = newProductdetailstable;
                grdPackingList.DataBind();
            }
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
              
                for (int i = 0; i <= 10; i++)
                {
                    DataRow PRow = PackingList.NewRow();
                    PRow["UniqueNo"] = newID++;
                    PRow["ItemCode"] = "";
                    PRow["Description"] = "";
                    PRow["BarCode"] = "";
                    PRow["UnitPrice"] = 0;
                    PRow["Quantity"] = 0;
                    PRow["Amount"] = 0;
                    PRow["NoofCartons"] = 0;
                    PRow["QtyinCarton"] = 0;
                    PRow["MFDate"] = "";
                    

                    PackingList.Rows.Add(PRow);


                }


                return PackingList;
            }
            catch (Exception ex)
            {

                throw;
            }


        }

       


    }
}