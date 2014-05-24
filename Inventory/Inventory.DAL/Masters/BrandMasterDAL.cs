using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.DAL.Masters
{
    public class BrandMasterDAL
    {
        public string Insert(BrandMaster objBrand)
        {
            try
            {
                using (var db = new InventoryEntities())
                {
                    db.BrandMasters.Add(objBrand);
                    db.SaveChanges();
                    return "suc";
                }
            }
            catch (Exception ex )
            {
                
                throw;
            }
        }

        public List<BrandMaster> GetBrandList( int? startIndex, int? maxRows)
        {
            int skip = startIndex == null ? 0 : startIndex.Value;
            int take = maxRows == null ? 0 : maxRows.Value;
            skip = skip * take;

            using (var db = new InventoryEntities())
            {

                var lstBrandList = (from td in db.BrandMasters where td.Status == 1 select td).OrderBy(d=>d.BrandID). Skip(skip).Take(take).ToList();
                return lstBrandList;
            }

        }

        public int GetBrandCount()
        {
            using (var db = new InventoryEntities())
            {
                return db.BrandMasters.Where(d => d.Status == 1).Count();
            }
        }
        public BrandMaster SelectSingle(int BrandID)
        {
            using (var db = new InventoryEntities())
            {
                return db.BrandMasters.Where(d => d.BrandID == BrandID).SingleOrDefault();
            }
        }
        public string Update(BrandMaster objBrandUpdate)
        {
            using (var db = new InventoryEntities())
            {
                var objBrand = db.BrandMasters.Where(d => d.BrandID == objBrandUpdate.BrandID).SingleOrDefault();
                objBrand.BrandName = objBrandUpdate.BrandName;
                objBrand.DateModified = objBrandUpdate.DateModified;
                objBrand.ModifiedBy = objBrandUpdate.ModifiedBy;
                db.SaveChanges();
                return "suc";
            }
        }
    }
}