﻿using System;
using System.Collections.Generic;
using System.Linq;
using entity = Inventory.DAL;

namespace Inventory.DAL.PurchaseOrders
{
    public static class ProductOrderExtention
    {
        public static int ToNullInt(this int? obj)
        {
            return Convert.ToInt16(obj);

        }

        public static decimal ToNullDecimal(this decimal? obj)
        {
            return Convert.ToDecimal(obj);
        }

        #region "Product"

        public static ProductMaster ToEntity(this ProductPurchaseOrderModel model)
        {

            return null;
        }

        public static ProductPurchaseOrderModel ToModel(this ProductMaster entity)
        {
            using (var db = new DAL.InventoryEntities())
            {
                ProductPurchaseOrderModel model = new ProductPurchaseOrderModel();
                model.Code = entity.ItemCode;
                model.BarCode = entity.MFBarcode;
                model.ProductID = entity.ProductID;
                model.Description = entity.Description;
                model.Cost = entity.BasicPC.ToNullDecimal();
                model.QtyPerCarton = entity.QPC.ToNullInt();
                var currency = db.CurrencyMasters.FirstOrDefault(x => x.CurrencyID == entity.CurrencyID) ?? new CurrencyMaster();
                model.CurrencyCode = currency.CurrencyCode;
                return model;

            }
        }

        #endregion

        #region "Purchase Order Item"

        public static PurchaseOrderDetail ToEntity(this PurchaseOrderItemModel model)
        {
            PurchaseOrderDetail entity = new PurchaseOrderDetail();
            entity.PurchaseOrderDetailID = model.PurchaseOrderDetailID;
            entity.PurchaseOrderID = model.PurchaseOrderID;
            entity.ProductID = model.ProductID;
            entity.Cost = model.Cost;
            entity.Quantity = model.Quantity;
            entity.Amount = model.Amount;

            return entity;
        }

        public static PurchaseOrderDetail ToEntity(this PurchaseOrderItemModel model, PurchaseOrderDetail entity)
        {
            entity.PurchaseOrderDetailID = model.PurchaseOrderDetailID;
            entity.PurchaseOrderID = model.PurchaseOrderID;
            entity.ProductID = model.ProductID;
            entity.Cost = model.Cost;
            entity.Quantity = model.Quantity;
            entity.Amount = model.Amount;

            return entity;
        }

        public static PurchaseOrderItemModel ToModel(this PurchaseOrderDetail entity)
        {
            PurchaseOrderItemModel model = new PurchaseOrderItemModel();
            model.PurchaseOrderDetailID = entity.PurchaseOrderDetailID;
            model.PurchaseOrderID = entity.PurchaseOrderID.ToNullInt();
            model.ProductID = entity.ProductID.ToNullInt();
            model.Cost = entity.Cost.ToNullDecimal();
            model.Quantity = entity.Quantity.ToNullInt();
            model.Amount = entity.Amount.ToNullDecimal();

            return model;
        }

        #endregion

        #region "Purchase Order"

        public static entity.PurchaseOrder ToEntity(this PurchaseOrderModel model)
        {
            entity.PurchaseOrder entity = new entity.PurchaseOrder();
            entity.PurchaseOrderID = model.PurchaseOrderID;
            entity.SupplierID = model.SupplierID;
            entity.PONumber = model.PONumber;
            entity.PODate = model.PODate;
            entity.Status = model.Status;
            return entity;
        }

        public static entity.PurchaseOrder ToEntity(this PurchaseOrderModel model, entity.PurchaseOrder entity)
        {
            entity.PurchaseOrderID = model.PurchaseOrderID;
            entity.SupplierID = model.SupplierID;
            // entity.PONumber = model.PONumber;
            entity.PODate = model.PODate;
            return entity;
        }

        public static PurchaseOrderModel ToModel(this entity.PurchaseOrder entity)
        {
            PurchaseOrderModel model = new PurchaseOrderModel();
            model.PurchaseOrderID = entity.PurchaseOrderID;
            model.SupplierID = entity.SupplierID.ToNullInt();
            // model.PONumber = entity.PONumber;
            model.PODate = Convert.ToDateTime(entity.PODate);


            return model;
        }


        #endregion

    }
}