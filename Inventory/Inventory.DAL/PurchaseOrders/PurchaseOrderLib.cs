using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Inventory.DAL.PurchaseOrders
{
    public class PurchaseOrderLib
    {
        public List<PurchaseOrder> GetListForDDL(int supplierId, string pOnumber, string startDate, string endDate)
        {
            DAL.InventoryEntities db = new DAL.InventoryEntities();

            DateTime dtStartDate = Convert.ToDateTime(DateTime.Parse(!string.IsNullOrEmpty(startDate) ? startDate : "1/jan/1901").ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            DateTime dtEndDate = Convert.ToDateTime(DateTime.Parse(!string.IsNullOrEmpty(startDate) ? startDate : "1/jan/2101").ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
            var objPurchaseOrderList = db.PurchaseOrders.Where(x => x.Status == 1
                && (supplierId == 0 | x.SupplierID == supplierId)
                && (string.IsNullOrEmpty(pOnumber) || x.PONumber == pOnumber)
                && ((string.IsNullOrEmpty(startDate) || x.PODate >= dtStartDate)
                && (string.IsNullOrEmpty(endDate) || x.PODate <= dtEndDate)
                )
                ).ToList();
            return objPurchaseOrderList;

        }

        public string GetPoNumbre()
        {
            int maxvalue = 0;
            string currentDateString = DateTime.Now.ToString("ddMMyyyy");

            DAL.InventoryEntities db = new DAL.InventoryEntities();
            List<PurchaseOrder> lstPoNumberList = db.PurchaseOrders.Where(x => x.PONumber.Contains(currentDateString)).ToList();
            if (lstPoNumberList.Count() > 0)
            {
                maxvalue = lstPoNumberList.Max(x => Convert.ToInt16(x.PONumber.Substring(11, x.PONumber.Length - 10 - 1)));
            }
            return string.Format("DEP{0}{1}", currentDateString, maxvalue + 1);
        }

        public PurchaseOrderModel GetPurchaseOrder(int purchaseOrderId)
        {
            using (var db = new DAL.InventoryEntities())
            {
                PurchaseOrder purchaseOrder = db.PurchaseOrders.FirstOrDefault(x => x.PurchaseOrderID == purchaseOrderId) ?? new PurchaseOrder();
                PurchaseOrderModel purchaseOrderModel = purchaseOrder.ToModel();

                purchaseOrderModel.PurchaseOrderItems = purchaseOrder.PurchaseOrderDetails.ToList().Select(x => x.ToModel()).ToList();

                List<ProductPurchaseOrderModel> Products = db.ProductMasters.OrderBy(x => x.ItemCode).ToList().Select(x => x.ToModel()).ToList();

                Products.Insert(0, new ProductPurchaseOrderModel() { Code = "-select-", ProductID = 0 });

                int productItemCount = purchaseOrderModel.PurchaseOrderItems.Count;

                for (int i = 0; i < 10 - productItemCount; i++)
                {
                    purchaseOrderModel.PurchaseOrderItems.Add(new PurchaseOrderItemModel());
                }

                purchaseOrderModel.PurchaseOrderItems.ForEach(x => x.Products = Products);

                return purchaseOrderModel;

            }
        }

        public List<ProductPurchaseOrderModel> GetProdutPruchaseOrder()
        {
            using (var db = new DAL.InventoryEntities())
            {
                List<ProductPurchaseOrderModel> Products = db.ProductMasters.OrderBy(x => x.ItemCode).ToList().Select(x => x.ToModel()).ToList();

                Products.Insert(0, new ProductPurchaseOrderModel() { Code = "-select-", ProductID = 0 });

                return Products;
            }

        }

        public string AddUpdatePurchaseOrder(PurchaseOrderModel model)
        {
            string result = "";
            try
            {
                using (var db = new DAL.InventoryEntities())
                {
                    PurchaseOrder purchaseOrder;
                    if (model.PurchaseOrderID <= 0)
                    {
                        purchaseOrder = model.ToEntity();
                        purchaseOrder.PONumber = GetPoNumbre();
                        purchaseOrder.DateCreated = DateTime.Now;
                        purchaseOrder.Status = 1;
                        db.PurchaseOrders.Add(purchaseOrder);
                        db.SaveChanges();
                        result = "Insert";
                    }
                    else
                    {
                        purchaseOrder = db.PurchaseOrders.FirstOrDefault(x => x.PurchaseOrderID == model.PurchaseOrderID);
                        purchaseOrder = model.ToEntity(purchaseOrder);
                        db.SaveChanges();
                        // Delete EXitsing Order
                        int[] extingIds = purchaseOrder.PurchaseOrderDetails.ToList().Select(x => x.PurchaseOrderDetailID).ToArray();
                        int[] detailIds = model.PurchaseOrderItems.Where(x => x.ProductID > 0 && x.Cost > 0).Select(x => x.PurchaseOrderDetailID).ToArray();

                        int[] deleteIds = extingIds.Except(detailIds).ToArray();
                        List<PurchaseOrderDetail> purchaseOrderDetail = purchaseOrder.PurchaseOrderDetails.Where(x => !detailIds.Contains(x.PurchaseOrderDetailID)).ToList();

                        foreach (PurchaseOrderDetail item in purchaseOrderDetail)
                        {
                            db.PurchaseOrderDetails.Remove(item);
                        }
                        db.SaveChanges();
                        result ="update";
                    }

                    model.PurchaseOrderItems.ForEach(x => x.PurchaseOrderID = purchaseOrder.PurchaseOrderID);

                    foreach (var productItem in model.PurchaseOrderItems.Where(x => x.ProductID > 0 && x.Cost > 0))
                    {
                        AddUpdatePurchaseOrderDetail(productItem);
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
            return result;
        }

        public PurchaseOrderDetail AddUpdatePurchaseOrderDetail(PurchaseOrderItemModel model)
        {
            using (var db = new DAL.InventoryEntities())
            {
                PurchaseOrderDetail purchaseOrderDetail;
                if (model.PurchaseOrderDetailID <= 0)
                {
                    purchaseOrderDetail = model.ToEntity();
                    db.PurchaseOrderDetails.Add(purchaseOrderDetail);
                }
                else
                {
                    purchaseOrderDetail = db.PurchaseOrderDetails.FirstOrDefault(x => x.PurchaseOrderDetailID == model.PurchaseOrderDetailID);
                    purchaseOrderDetail = model.ToEntity(purchaseOrderDetail);

                }
                db.SaveChanges();
                return purchaseOrderDetail;
            }
        }

    }
}