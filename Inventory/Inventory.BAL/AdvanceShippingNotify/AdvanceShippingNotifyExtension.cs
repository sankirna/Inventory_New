using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Inventory.DAL;
using Inventory.Utility;
using entity = Inventory.DAL;

namespace Inventory.BAL.AdvanceShippingNotify
{
    public static class AdvanceShippingNotifyExtension
    {

        #region Currency

        public static CurrencyModel ToModel(this entity.CurrencyMaster dbEntity)
        {
            CurrencyModel model = new CurrencyModel();
            model.CurrencyId = dbEntity.CurrencyID;
            model.CurrencyName = dbEntity.CurrencyName;
            return model;
        }

        #endregion

        #region "Product"

        public static ProductAdvanceShipping ToModel(this entity.PurchaseOrderDetail dbentity)
        {
            using (var db = new DAL.InventoryEntities())
            {
                entity.ProductMaster product = dbentity.ProductMaster;

                ProductAdvanceShipping model = new ProductAdvanceShipping();
                model.Code = product.ItemCode;
                model.BarCode = product.MFBarcode;
                model.ProductID = product.ProductID;
                model.Description = product.Description;

                model.QtyPerCarton = product.QPC.ToNullInt();
                var currency = db.CurrencyMasters.FirstOrDefault(x => x.CurrencyID == product.CurrencyID) ?? new entity.CurrencyMaster();
                model.CurrencyCode = currency.CurrencyCode;

                model.Cost = dbentity.Cost;
                model.Quantity = dbentity.Quantity;
                model.Amount = dbentity.Amount;

                return model;

            }
        }

        #endregion

        #region AdvanceShippingNotify

        public static entity.AdvanceShipping ToEntity(this AdvanceShippingNotifyModels model)
        {
            entity.AdvanceShipping entity = new entity.AdvanceShipping();
            entity.ASNID = model.ASNID;
            entity.PONumber = model.PONumber;
            entity.PurchaseOrderID = model.PurchaseOrderID;
            entity.SupplierID = model.SupplierID;
            entity.ETA = model.ETA.GetStringToFormatedDate();
            entity.ASNNo = model.ASNNo;
            entity.PINo = model.PINo;
            entity.InvoiceNo = model.InvoiceNo;
            entity.TotalM3 = model.TotalM3;
            entity.FromCountry = model.FromCountry;
            entity.ToCountry = model.ToCountry;
            entity.ShippingMethod = model.ShippingMethod;
            entity.TradeTerms = model.TradeTerms;

            return entity;
        }

        public static entity.AdvanceShipping ToEntity(this AdvanceShippingNotifyModels model, entity.AdvanceShipping entity)
        {
            model.PurchaseOrderID = entity.PurchaseOrderID;
            entity.ASNID = model.ASNID;
            entity.PONumber = model.PONumber;
            entity.PurchaseOrderID = model.PurchaseOrderID;
            entity.SupplierID = model.SupplierID;
            entity.ETA = model.ETA.GetStringToFormatedDate();
         //   entity.ASNNo = model.ASNNo;
            entity.PINo = model.PINo;
            entity.InvoiceNo = model.InvoiceNo;
            entity.TotalM3 = model.TotalM3;
            entity.FromCountry = model.FromCountry;
            entity.ToCountry = model.ToCountry;
            entity.ShippingMethod = model.ShippingMethod;
            entity.TradeTerms = model.TradeTerms;

            return entity;
        }

        public static AdvanceShippingNotifyModels ToModel(this entity.AdvanceShipping entity, int purchaseOrderID)
        {
            using (var db = new DAL.InventoryEntities())
            {
                AdvanceShippingNotifyModels model = new AdvanceShippingNotifyModels();
                entity.PurchaseOrder purchaseOrder = db.PurchaseOrders.FirstOrDefault(x => x.PurchaseOrderID == purchaseOrderID);
                entity.SupplierMaster supplier = purchaseOrder.SupplierMaster;

                model.PurchaseOrderID = entity.PurchaseOrderID;
                model.PONumber = purchaseOrder.PONumber;
                model.PODate = Convert.ToDateTime(purchaseOrder.PODate).GetForamttedDate();

                model.SupplierID = supplier.SupplierID;
                model.SupplierName = supplier.SupplierName;

                model.ETA = entity.ETA.ToStringFromObject();
                model.PINo = entity.PINo;
                model.InvoiceNo = entity.InvoiceNo;
                model.TotalM3 = entity.TotalM3.ToNullDecimal();
                model.FromCountry = entity.FromCountry.ToNullInt();
                model.ToCountry = entity.ToCountry.ToNullInt();

                model.ShippingMethod = entity.ShippingMethod;
                model.TradeTerms = entity.TradeTerms.ToStringFromObject();
                model.ASNID = entity.ASNID;

                //model.p

                //model.DateOfShipment = entity.DateOfShipment;
                return model;
            }
        }

        #endregion

        #region AdvanceShippingProductDetailModel

        public static entity.AdvanceShippingProductDetail ToEntity(this AdvanceShippingProductDetailModel model)
        {
            entity.AdvanceShippingProductDetail entity = new entity.AdvanceShippingProductDetail();
            //entity.ASNProductDetailsID = model.AsnProductDetailsId;
            //entity.ASNID = model.ASNID;
            //entity.ProductID = model.ProductId;
            //entity.UnitPrice = model.UnitPrice;
            //entity.CurrencyID = model.CurrencyID;
            //entity.Qty = model.Qty;
            //entity.MFDate = model.MFDate.GetStringToFormatedDate();
            //entity.ExpiryDate = model.ExpiryDate;
            //entity.NoofCartons = model.NoofCartons;
            //entity.Rate = model.Rate;

            return entity;
        }

        public static entity.AdvanceShippingProductDetail ToEntity(this AdvanceShippingProductDetailModel model, entity.AdvanceShippingProductDetail entity)
        {
            //model.AsnProductDetailsId = entity.ASNProductDetailsID;
            //model.ASNID = entity.ASNID;
            //model.ProductId = entity.ProductID.ToNullInt();
            //model.UnitPrice = entity.UnitPrice;
            //model.CurrencyID = entity.CurrencyID;
            //model.Qty = entity.Qty;
            //model.ExpiryDate = entity.ExpiryDate;
            //model.NoofCartons = entity.NoofCartons;
            //model.Rate = entity.Rate;


            return entity;
        }

        //public static AdvanceShippingProductDetailModel ToModel(this entity.AdvanceShippingProductDetail entity)
        //{
        //    AdvanceShippingProductDetailModel model = new AdvanceShippingProductDetailModel();
        //    //model.AsnProductDetailsId = entity.ASNProductDetailsID;
        //    //model.ASNID = entity.ASNID;
        //    //model.ProductId = entity.ProductID.ToNullInt();
        //    //model.UnitPrice = entity.UnitPrice;
        //    //model.CurrencyID = entity.CurrencyID;
        //    //model.Qty = entity.Qty;
        //    //model.MFDate = Convert.ToDateTime(entity.MFDate).GetForamttedDate();
        //    //model.ExpiryDate = entity.ExpiryDate;
        //    //model.NoofCartons = entity.NoofCartons;
        //    //model.Rate = entity.Rate;

        //    return model;
        //}

        public static AdvanceShippingProductDetailModel ToAdvanceShippingProductDetailModel(this entity.PurchaseOrderDetail dbEntity)
        {
            AdvanceShippingProductDetailModel model = new AdvanceShippingProductDetailModel();

            entity.ProductMaster productMaster = dbEntity.ProductMaster ?? new entity.ProductMaster();

            //model.ASNID = dbEntity.ASNID;
            //model.AsnProductDetailsId = dbEntity.AsnProductDetailsId;
            //model.CartonStartingNo = dbEntity.CartonStartingNo;
            //model.CartonEndingNo = dbEntity.CartonEndingNo;
            model.ProductId = dbEntity.ProductID.ToNullInt();
            model.PurchaseOrderDetailProductId = dbEntity.PurchaseOrderDetailID;
            model.ItemCode = productMaster.ItemCode;
            model.Description = productMaster.Description;
            model.BarCode = productMaster.MFBarcode;
            model.UnitPrice = dbEntity.Cost.ToNullDecimal();
            model.Quantity = dbEntity.Quantity.ToNullInt();
            model.Amount = dbEntity.Amount.ToNullDecimal();
            //model.CountryId = dbEntity.CountryId;
            //model.SizeMM = dbEntity.SizeMM;
            //model.GWKG = dbEntity.GWKG;
            //model.NWKG = dbEntity.NWKG;
            //model.NoofCartons = dbEntity.NoofCartons;
            //model.WeightCarton = dbEntity.WeightCarton;
            //model.QuantityCarton = dbEntity.QuantityCarton;
            //model.MFDate = dbEntity.MFDate;


            return model;
        }


        public static AdvanceShippingProductDetailModel ToModel(this entity.AdvanceShippingProductDetail dbEntity)
        {
            AdvanceShippingProductDetailModel model = new AdvanceShippingProductDetailModel();

            entity.ProductMaster productMaster = dbEntity.ProductMaster ?? new entity.ProductMaster();

            model.ASNID = dbEntity.ASNID.ToNullInt();
            model.AsnProductDetailsId = dbEntity.ASNProductDetailsID;
            model.ProductId = dbEntity.ProductID.ToNullInt();
            model.PurchaseOrderDetailProductId = dbEntity.ProductOrderProductId.ToNullInt();
            model.ItemCode = productMaster.ItemCode;
            model.Description = productMaster.Description;
            model.BarCode = productMaster.MFBarcode;
            model.UnitPrice = dbEntity.UnitPrice.ToNullDecimal();
            model.Quantity = dbEntity.Qty.ToNullInt();
            model.Amount = dbEntity.Rate.ToNullDecimal();
            model.CountryId = dbEntity.CurrencyID.ToNullInt();
            model.SizeMM = dbEntity.SizeMM;
            model.GWKG = dbEntity.GWKG;
            model.NWKG = dbEntity.NWKG;
            model.NoofCartons = dbEntity.NoofCartons.ToNullInt();
            model.WeightCarton = dbEntity.WeightCarton;
            //    model.QuantityCarton = dbEntity.QuantityCarton.;
            model.MFDate = Convert.ToDateTime(dbEntity.MFDate).GetForamttedDate();


            return model;
        }


        #endregion


        #region Adv shipping List model

        public static AdvanceShippingModel ToModel(this entity.AdvanceShipping entity)
        {
            using (var db = new DAL.InventoryEntities())
            {
                AdvanceShippingModel model = new AdvanceShippingModel();

                model.ASNID = entity.ASNID;
                model.PurchaseOrderID = entity.PurchaseOrderID;
                model.ASNNo = entity.ASNNo;
                model.ETA = Convert.ToDateTime(entity.ETA).GetForamttedDate();
                model.PONumber = entity.PONumber;

                PurchaseOrder po = entity.PurchaseOrder ?? new PurchaseOrder();
                SupplierMaster sm = entity.SupplierMaster ?? new SupplierMaster();
                model.PODate = Convert.ToDateTime(po.PODate).GetForamttedDate(); //po.PODate.ToStringFromObject();
                model.SupplierName = sm.SupplierName;

                return model;
            }
        }

        #endregion
    }
}