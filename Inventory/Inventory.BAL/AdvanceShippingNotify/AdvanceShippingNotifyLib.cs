using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.BAL.PurchaseOrdersBO;
using Inventory.DAL;

namespace Inventory.BAL.AdvanceShippingNotify
{
    public class AdvanceShippingNotifyLib
    {
        public List<ProductAdvanceShipping> GetProductAdvance(int purchaseOrderId)
        {
            using (var db = new DAL.InventoryEntities())
            {
                List<ProductAdvanceShipping> products = db.PurchaseOrderDetails.Where(x => x.PurchaseOrderID == purchaseOrderId).ToList().Select(x => x.ToModel()).ToList();
                products.Insert(0, new ProductAdvanceShipping() { Code = "-select-", ProductID = 0 });

                return products;
            }
        }

        public AdvanceShippingNotifyModels GetAdvanceShippingNotify(int purchaseOrderId)
        {
            using (var db = new DAL.InventoryEntities())
            {
                DAL.AdvanceShipping advanceShipping = db.AdvanceShippings.FirstOrDefault(x => x.PurchaseOrderID == purchaseOrderId) ?? new DAL.AdvanceShipping();
                AdvanceShippingNotifyModels advanceShippingProductDetailModel = advanceShipping.ToModel();

                advanceShippingProductDetailModel.AdvanceShippingProductDetails = advanceShipping.AdvanceShippingProductDetails.ToList().Select(x => x.ToModel()).ToList();

                List<ProductAdvanceShipping> Products = GetProductAdvance(purchaseOrderId);

                int productItemCount = Products.Count;

                for (int i = 0; i < productItemCount - advanceShippingProductDetailModel.AdvanceShippingProductDetails.Count; i++)
                {
                    advanceShippingProductDetailModel.AdvanceShippingProductDetails.Add(new AdvanceShippingProductDetailModel());
                }

                advanceShippingProductDetailModel.AdvanceShippingProductDetails.ForEach(x => x.Products = Products);
                return advanceShippingProductDetailModel;

            }
        }

        public string AddUpdateAdvanceShipping(AdvanceShippingNotifyModels model)
        {
            string result = "";
            try
            {
                using (var db = new DAL.InventoryEntities())
                {
                    DAL.AdvanceShipping advanceShipping;
                    if (model.ASNID <= 0)
                    {
                        advanceShipping = model.ToEntity();
                        advanceShipping.ASNNo = "123";
                        advanceShipping.DateCreated = DateTime.Now;
                        advanceShipping.Status = 1;
                        advanceShipping.SupplierID = 1;
                        db.AdvanceShippings.Add(advanceShipping);
                        db.SaveChanges();
                        result = "Insert";
                    }
                    else
                    {
                        advanceShipping = db.AdvanceShippings.FirstOrDefault(x => x.ASNID == model.ASNID);
                        advanceShipping = model.ToEntity(advanceShipping);
                        db.SaveChanges();
                        // Delete EXitsing Order
                        int[] extingIds = advanceShipping.AdvanceShippingProductDetails.ToList().Select(x => x.ASNProductDetailsID).ToArray();
                        int[] detailIds = model.AdvanceShippingProductDetails.Where(x => x.ProductID > 0 && x.Rate > 0).Select(x => x.ASNProductDetailsID).ToArray();

                        int[] deleteIds = extingIds.Except(detailIds).ToArray();
                        List<AdvanceShippingProductDetail> advanceShippingProductDetails = advanceShipping.AdvanceShippingProductDetails.Where(x => !deleteIds.Contains(x.ASNProductDetailsID)).ToList();

                        foreach (AdvanceShippingProductDetail item in advanceShippingProductDetails)
                        {
                            db.AdvanceShippingProductDetails.Remove(item);
                        }
                        db.SaveChanges();
                        result = "update";
                    }

                    model.AdvanceShippingProductDetails.ForEach(x => x.ASNID = advanceShipping.ASNID);

                    foreach (var advanceShippingProductDetail in model.AdvanceShippingProductDetails.Where(x => x.ProductID > 0 && x.Rate > 0))
                    {
                        AddUpdateAdvanceShippingProductDetail(advanceShippingProductDetail);
                    }
                   
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return result;
        }

        public AdvanceShippingProductDetail AddUpdateAdvanceShippingProductDetail(AdvanceShippingProductDetailModel model)
        {
            using (var db = new DAL.InventoryEntities())
            {
                AdvanceShippingProductDetail advanceShippingProductDetail;
                if (model.ASNProductDetailsID <= 0)
                {
                    advanceShippingProductDetail = model.ToEntity();
                    db.AdvanceShippingProductDetails.Add(advanceShippingProductDetail);
                }
                else
                {
                    advanceShippingProductDetail = db.AdvanceShippingProductDetails.FirstOrDefault(x => x.ASNProductDetailsID == model.ASNProductDetailsID);
                    advanceShippingProductDetail = model.ToEntity(advanceShippingProductDetail);

                }
                db.SaveChanges();
                return advanceShippingProductDetail;
            }
        }
    }
}