using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Inventory.Utility;

namespace Inventory.DAL.Masters
{
    public class CategoryMasterDAL
    {
        public string Insert(CategoryMaster insCategoryMaster)
        {
            using (var db = new InventoryEntities())
            {
                db.CategoryMasters.Add(insCategoryMaster);
                db.SaveChanges();
                return "suc";
            }
        }

        public CategoryMaster SelectSingleMaster(int categoryId)
        {
            using (var db = new InventoryEntities())
            {
                return db.CategoryMasters.SingleOrDefault(d => d.CategoryID == categoryId);
            }
        }

        public string Delete(int categoryId)
        {
            using (var db = new InventoryEntities())
            {
                CategoryMaster categoryMaster = db.CategoryMasters.SingleOrDefault(d => d.CategoryID == categoryId);
                categoryMaster.DateModified = System.DateTime.Now;
                categoryMaster.ModifiedBy = SessionManager.UserId;
                categoryMaster.Status = 0;
                db.SaveChanges();
                return "suc";


            }
        }

        public string Update(CategoryMaster updateCategoryMaster)
        {
            using (var db = new InventoryEntities())
            {
                db.CategoryMasters.Attach(updateCategoryMaster);
                var objentry = db.Entry(updateCategoryMaster);
                objentry.Property(e => e.CategoryName).IsModified = true;
                objentry.Property(e => e.DateModified).IsModified = true;
                objentry.Property(e => e.ModifiedBy).IsModified = true;
                db.SaveChanges();
                return "suc";
            }
        }

        public List<CategoryMaster> GetList( int? pageIndex, int? maxRows)
        {
             int skip = pageIndex == null ? 0 : pageIndex.Value;
            int take = maxRows == null ? 0 : maxRows.Value;
            skip = skip * take;
            using (var db = new InventoryEntities())
            {
               
               
                    return
                        db.CategoryMasters.Where(
                            d =>
                                d.Status == 1)
                            .OrderBy(d => d.DateCreated)
                            .Skip(skip)
                            .Take(take)
                            .ToList();
                
            }
        }

        public int GetCategoryCount()
        {
            using (var db = new InventoryEntities())
            {
                
                    return
                       db.CategoryMasters.Count(
                           d =>
                               d.Status == 1 
                          );
                        
                
            }
        }
    }
}
