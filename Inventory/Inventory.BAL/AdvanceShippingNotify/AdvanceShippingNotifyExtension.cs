using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inventory.Utility;
using entity = Inventory.DAL;

namespace Inventory.BAL.AdvanceShippingNotify
{
    public static class AdvanceShippingNotifyExtension
    {
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
            entity.SupplierID = model.SupplierID;
            entity.DateOfShipment = model.DateOfShipment;
            entity.ASNNo = model.ASNNo;
            return entity;
        }

        public static entity.AdvanceShipping ToEntity(this AdvanceShippingNotifyModels model, entity.AdvanceShipping entity)
        {
            model.ASNID = entity.ASNID;
            model.PONumber = entity.PONumber;
            model.SupplierID = entity.SupplierID;
            model.DateOfShipment = entity.DateOfShipment;

            return entity;
        }

        public static AdvanceShippingNotifyModels ToModel(this entity.AdvanceShipping entity)
        {
            AdvanceShippingNotifyModels model = new AdvanceShippingNotifyModels();
            entity.SupplierMaster supplier = entity.SupplierMaster ?? new entity.SupplierMaster();
            model.ASNID = entity.ASNID;
            model.PONumber = entity.PONumber;
            model.SupplierID = entity.SupplierID;
            model.SupplierName = supplier.SupplierName;
            model.DateOfShipment = entity.DateOfShipment;

            return model;
        }

        #endregion

        #region AdvanceShippingProductDetailModel

        public static entity.AdvanceShippingProductDetail ToEntity(this AdvanceShippingProductDetailModel model)
        {
            entity.AdvanceShippingProductDetail entity = new entity.AdvanceShippingProductDetail();
            entity.ASNProductDetailsID = model.ASNProductDetailsID;
            entity.ASNID = model.ASNID;
            entity.ProductID = model.ProductID;
            entity.UnitPrice = model.UnitPrice;
            entity.CurrencyID = model.CurrencyID;
            entity.Qty = model.Qty;
            entity.MFDate = model.MFDate.GetStringToFormatedDate();
            entity.ExpiryDate = model.ExpiryDate;
            entity.NoofCartons = model.NoofCartons;
            entity.Rate = model.Rate;

            return entity;
        }

        public static entity.AdvanceShippingProductDetail ToEntity(this AdvanceShippingProductDetailModel model, entity.AdvanceShippingProductDetail entity)
        {
            model.ASNProductDetailsID = entity.ASNProductDetailsID;
            model.ASNID = entity.ASNID;
            model.ProductID = entity.ProductID.ToNullInt();
            model.UnitPrice = entity.UnitPrice;
            model.CurrencyID = entity.CurrencyID;
            model.Qty = entity.Qty;
            model.ExpiryDate = entity.ExpiryDate;
            model.NoofCartons = entity.NoofCartons;
            model.Rate = entity.Rate;


            return entity;
        }

        public static AdvanceShippingProductDetailModel ToModel(this entity.AdvanceShippingProductDetail entity)
        {
            AdvanceShippingProductDetailModel model = new AdvanceShippingProductDetailModel();
            model.ASNProductDetailsID = entity.ASNProductDetailsID;
            model.ASNID = entity.ASNID;
            model.ProductID = entity.ProductID.ToNullInt();
            model.UnitPrice = entity.UnitPrice;
            model.CurrencyID = entity.CurrencyID;
            model.Qty = entity.Qty;
            model.MFDate = Convert.ToDateTime(entity.MFDate).GetForamttedDate();
            model.ExpiryDate = entity.ExpiryDate;
            model.NoofCartons = entity.NoofCartons;
            model.Rate = entity.Rate;

            return model;
        }

        #endregion
    }
}