using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.BAL.PurchaseOrdersBO;
using Inventory.DAL;
using Inventory.Utility;

namespace Inventory.BAL.AdvanceShippingNotify
{
    public class AdvanceShippingNotifyLib
    {
        #region External Method

        public List<ProductAdvanceShipping> GetProductAdvance(int purchaseOrderId)
        {
            using (var db = new DAL.InventoryEntities())
            {
                List<ProductAdvanceShipping> products = db.PurchaseOrderDetails.Where(x => x.PurchaseOrderID == purchaseOrderId).ToList().Select(x => x.ToModel()).ToList();
                products.Insert(0, new ProductAdvanceShipping() { Code = "-select-", ProductID = 0 });

                return products;
            }
        }

        public List<CurrencyModel> GetCurrencyMasters()
        {
            using (var db = new DAL.InventoryEntities())
            {
                return db.CurrencyMasters.ToList().Select(x => x.ToModel()).ToList();
            }
        }

        #endregion



        public AdvanceShippingNotifyModels GetAdvanceShippingNotify(int purchaseOrderId,int asnId=0)
        {
            using (var db = new DAL.InventoryEntities())
            {
                DAL.AdvanceShipping advanceShipping = db.AdvanceShippings.FirstOrDefault(x => x.ASNID == asnId) ?? new DAL.AdvanceShipping();
                AdvanceShippingNotifyModels advanceShippingProductDetailModel = advanceShipping.ToModel(purchaseOrderId);

                // advanceShippingProductDetailModel.AdvanceShippingProductDetails = advanceShipping.AdvanceShippingProductDetails.ToList().Select(x => x.ToModel()).ToList();
                advanceShippingProductDetailModel.PurchaseOrderID = purchaseOrderId;

                if (asnId <= 0)
                {
                    List<PurchaseOrderDetail> purchaseOrderDetails =
                        db.PurchaseOrderDetails.Where(x => x.PurchaseOrderID == purchaseOrderId).ToList();

                    List<AdvanceShippingProductDetail> advanceShippingProductDetails =
                        db.AdvanceShippingProductDetails.Where(x => x.AdvanceShipping.PurchaseOrderID == purchaseOrderId)
                            .ToList();


                    int[] ids = advanceShippingProductDetails.Select(x => x.ProductOrderProductId.ToNullInt()).ToArray();

                    foreach (
                        PurchaseOrderDetail purchaseOrderDetail in
                            purchaseOrderDetails.Where(x => !ids.Contains(x.PurchaseOrderDetailID)))
                    {
                        advanceShippingProductDetailModel.AdvanceShippingProductDetails.Add(
                            purchaseOrderDetail.ToAdvanceShippingProductDetailModel());
                    }
                }



                List<CurrencyModel> currencyModels = GetCurrencyMasters();
                advanceShippingProductDetailModel.AdvanceShippingProductDetails.ForEach(x => x.CurrencyModels = currencyModels);
                return advanceShippingProductDetailModel;

            }
        }

        public string AddUpdateAdvanceShipping(AdvanceShippingNotifyModels model)
        {
            string result = "";
            try
            {
                using (var transaction = new System.Transactions.TransactionScope())
                using (var db = new DAL.InventoryEntities())
                {
                    DAL.AdvanceShipping advanceShipping;
                    if (model.ASNID <= 0)
                    {
                        advanceShipping = model.ToEntity();
                        advanceShipping.ASNNo = "123";
                        advanceShipping.CreatedBy = 1;
                        advanceShipping.DateCreated = DateTime.Now;
                        advanceShipping.Status = 1;
                        db.AdvanceShippings.Add(advanceShipping);
                        db.SaveChanges();
                        result = "Insert";
                    }
                    else
                    {
                        advanceShipping = db.AdvanceShippings.FirstOrDefault(x => x.ASNID == model.ASNID);
                        advanceShipping = model.ToEntity(advanceShipping);
                        db.SaveChanges();
                        //// Delete EXitsing Order
                        //int[] extingIds = advanceShipping.AdvanceShippingProductDetails.ToList().Select(x => x.ASNProductDetailsID).ToArray();
                        //int[] detailIds = model.AdvanceShippingProductDetails.Where(x => x.ProductId > 0 && x.Rate > 0).Select(x => x.AsnProductDetailsId).ToArray();

                        //int[] deleteIds = extingIds.Except(detailIds).ToArray();
                        //List<AdvanceShippingProductDetail> advanceShippingProductDetails = advanceShipping.AdvanceShippingProductDetails.Where(x => !deleteIds.Contains(x.ASNProductDetailsID)).ToList();

                        //foreach (AdvanceShippingProductDetail item in advanceShippingProductDetails)
                        //{
                        //    db.AdvanceShippingProductDetails.Remove(item);
                        //}
                        //db.SaveChanges();
                        //result = "update";
                    }

                    // TODO SetLogic here while update record
                    if (model.ASNID > 0)
                    {
                        model.AdvanceShippingProductDetails.ForEach(x => x.ASNID = advanceShipping.ASNID);
                        List<AdvanceShippingProductDetailModel> filtermodel =
                            model.AdvanceShippingProductDetails.Where(
                                x => x.MFDate.GetStringToFormatedDate() != new DateTime() && x.Amount >= 0).ToList();
                        foreach (AdvanceShippingProductDetailModel advanceShippingProductDetailModel in filtermodel)
                        {
                            // Save Adv Shiping Detail
                            AdvanceShippingProductDetail entity = new AdvanceShippingProductDetail();
                            //  entity.ASNProductDetailsID = advanceShippingProductDetailModel.AsnProductDetailsId;
                            entity.ASNID = advanceShippingProductDetailModel.ASNID;
                            entity.ProductOrderProductId =
                                advanceShippingProductDetailModel.PurchaseOrderDetailProductId > 0
                                    ? advanceShippingProductDetailModel.PurchaseOrderDetailProductId
                                    : (int?) null;
                            entity.ProductID = advanceShippingProductDetailModel.ProductId;
                            entity.UnitPrice = advanceShippingProductDetailModel.UnitPrice;
                            entity.CurrencyID = advanceShippingProductDetailModel.CountryId;
                            entity.Qty = advanceShippingProductDetailModel.Quantity;
                            entity.MFDate = advanceShippingProductDetailModel.MFDate.GetStringToFormatedDate();
                            entity.ExpiryDate =
                                advanceShippingProductDetailModel.MFDate.GetStringToFormatedDate().AddYears(1);
                            entity.NoofCartons = advanceShippingProductDetailModel.NoofCartons;
                            entity.Rate = advanceShippingProductDetailModel.Amount;
                            entity.SizeMM = advanceShippingProductDetailModel.SizeMM;
                            entity.GWKG = advanceShippingProductDetailModel.GWKG;
                            entity.NWKG = advanceShippingProductDetailModel.NWKG;
                            entity.WeightCarton = advanceShippingProductDetailModel.WeightCarton;
                            entity.Status = 1;
                            db.AdvanceShippingProductDetails.Add(entity);
                            db.SaveChanges();

                            for (int i = 1; i <= entity.NoofCartons; i++)
                            {
                                CartonBarCodeDetail cartonBarCodeDetails = new CartonBarCodeDetail();
                                cartonBarCodeDetails.ASNProductDetailsID = entity.ASNProductDetailsID;
                                cartonBarCodeDetails.BarCodeNo = string.Format("BR{0}", entity.ASNProductDetailsID);
                                cartonBarCodeDetails.CartonID = string.Format("CR{0}", i);
                                cartonBarCodeDetails.Quantity = advanceShippingProductDetailModel.QuantityCarton;
                                db.CartonBarCodeDetails.Add(cartonBarCodeDetails);
                            }
                            db.SaveChanges();
                        }
                    }
                    transaction.Complete();
                }
            }
            catch (Exception ex)
            {

                result = "some Error coming pls try later fill valid values";
            }

            return result;
        }

        public AdvanceShippingProductDetail AddUpdateAdvanceShippingProductDetail(AdvanceShippingProductDetailModel model)
        {
            using (var db = new DAL.InventoryEntities())
            {
                AdvanceShippingProductDetail advanceShippingProductDetail;
                if (model.AsnProductDetailsId <= 0)
                {
                    advanceShippingProductDetail = model.ToEntity();
                    db.AdvanceShippingProductDetails.Add(advanceShippingProductDetail);
                }
                else
                {
                    advanceShippingProductDetail = db.AdvanceShippingProductDetails.FirstOrDefault(x => x.ASNProductDetailsID == model.AsnProductDetailsId);
                    advanceShippingProductDetail = model.ToEntity(advanceShippingProductDetail);

                }
                db.SaveChanges();
                return advanceShippingProductDetail;
            }
        }

       
    }
}