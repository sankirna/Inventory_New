using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using Inventory.Utility;

namespace Inventory.DAL.Masters
{
    public class ProductDTO
    {



        public string Insert(ProductMaster InsertData)
        {
            try
            {
                using (var db = new InventoryEntities())
                {
                    db.ProductMasters.Add(InsertData);
                    db.SaveChanges();
                    return "suc";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public  List<ProductMaster> GetProductList(bool isOnPageLoad, int? startIndex, int? maxRows,int? SupplierID)
            
        {
            int skip = startIndex == null ? 0 : startIndex.Value;
            int take = maxRows == null ? 0 : maxRows.Value;
            skip = skip * take;

            using (var db = new InventoryEntities())
            {
              
                if (isOnPageLoad) 
                {
                    var LstProducts = (from td in db.ProductMasters where td.Status == 1 && DbFunctions.TruncateTime( td.DateCreated)== DbFunctions.TruncateTime(System.DateTime.Now) select td).OrderBy(d => d.DateCreated).Skip(skip).Take(take).ToList();

                    return LstProducts;
                }
                else
                {
                    if (SupplierID==0)
                    {
                        var LstProducts = (from td in db.ProductMasters where td.Status == 1  select td).OrderBy(d => d.DateCreated).Skip(skip).Take(take).ToList();
                        return LstProducts;
                    }
                    else
                    {
                        var LstProducts = (from td in db.ProductMasters where td.Status == 1 && td.SupplierID==SupplierID.Value select td).OrderBy(d => d.DateCreated).Skip(skip).Take(take).ToList();
                        return LstProducts;
                    }
                   
                }

            }
        }
        public  int GetProductCount(bool isOnPageLoad ,int SupplierID)
        {
         using (var db = new InventoryEntities())
            {
              
                if (isOnPageLoad) 
                {



                    return db.ProductMasters.Where(d => DbFunctions.TruncateTime(d.DateCreated) == DbFunctions.TruncateTime(System.DateTime.Now) && d.Status == 1).Count();
                }
                else
                {
                    if (SupplierID == 0)
                    {
                        return db.ProductMasters.Where(d => d.Status == 1).Count();
                    }
                    else
                    {
                        return db.ProductMasters.Where(d => d.Status == 1 && d.SupplierID==SupplierID).Count();
                    }
                   
                }

            }
        }
        public ProductMaster BindDataById(int id)
        {
            try
            {
                using (var db = new InventoryEntities())
                {
                    return db.ProductMasters.FirstOrDefault(c => c.ProductID == id);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string Update(ProductMaster updateData)
        {
            try
            {
                using (var db = new InventoryEntities())
                {
                    ProductMaster productMaster = db.ProductMasters.First(c => c.ProductID == updateData.ProductID);
                    productMaster.BasicPC = updateData.BasicPC;
                    productMaster.DateModified = updateData.DateModified;
                    productMaster.Description = updateData.Description;
                    productMaster.DiBreadth = updateData.DiBreadth;
                    productMaster.DiHeight = updateData.DiHeight;
                    productMaster.DiLength = updateData.DiLength;
                    productMaster.DiWeight = updateData.DiWeight;
                    productMaster.ItemCode = updateData.ItemCode;
                    productMaster.MFBarcode = updateData.MFBarcode;
                    productMaster.ModifiedBy = updateData.ModifiedBy;
                    productMaster.QPC = updateData.QPC;
                    productMaster.ShelfLife = updateData.ShelfLife;
                    productMaster.SpBreadth = updateData.SpBreadth;
                    productMaster.SpHeight = updateData.SpHeight;
                    productMaster.SpLength = updateData.SpLength;
                    productMaster.SpWeight = updateData.SpWeight;
                    productMaster.SRP = updateData.SRP;
                    productMaster.SupplierID = updateData.SupplierID;
                    productMaster.UOMID = updateData.UOMID;
                    db.SaveChanges();
                    return "suc";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string Delete(int ProductID)
        {
            try
            {
                using (var db = new InventoryEntities())
                {
                    var objProduct = db.ProductMasters.Where(td => td.ProductID == ProductID).SingleOrDefault();
                    objProduct.Status = 0;
                    db.SaveChanges();
                    return "suc";
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}