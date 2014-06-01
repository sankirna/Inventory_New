using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using Inventory.DAL;

namespace Inventory.BAL.AdvanceShippingNotify
{
    public class AdvanceShippingLib
    {
        public List<AdvanceShippingModel> GetList(int supplierId, string pOnumber, string startDate, string endDate, bool onPageload, int? startIndex, int? maxRows)
        {
            int skip = startIndex == null ? 0 : startIndex.Value;
            int take = maxRows == null ? 0 : maxRows.Value;
            skip = skip * take;
            var db = new InventoryEntities();
            {

                DateTime dtStartDate = Convert.ToDateTime(
                        DateTime.Parse(!string.IsNullOrEmpty(startDate) ? startDate : "1/jan/1901")
                            .ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                DateTime dtEndDate =
                    Convert.ToDateTime(
                        DateTime.Parse(!string.IsNullOrEmpty(startDate) ? startDate : "1/jan/2101")
                            .ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                if (onPageload)
                {
                    var objPurchaseOrderList = db.AdvanceShippings.Where(x => x.Status == 1
                                                                      && DbFunctions.TruncateTime(x.DateCreated) == DbFunctions.TruncateTime(System.DateTime.Now
                                                                           )
                   ).OrderBy(d => d.DateCreated).Skip(skip).Take(take).ToList();
                    return objPurchaseOrderList.Select(x=>x.ToModel()).ToList();
                }
                else
                {
                    var objPurchaseOrderList = db.AdvanceShippings.Where(x => x.Status == 1
                                                                   &&
                                                                   (supplierId == 0 | x.SupplierID == supplierId)
                                                                   &&
                                                                   (string.IsNullOrEmpty(pOnumber) ||
                                                                    x.PONumber == pOnumber)
                                                                   &&
                                                                   ((string.IsNullOrEmpty(startDate) ||
                                                                     x.PurchaseOrder.PODate >= dtStartDate)
                                                                    &&
                                                                    (string.IsNullOrEmpty(endDate) ||
                                                                     x.PurchaseOrder.PODate <= dtEndDate)
                                                                       )
               ).Include(d => d.SupplierMaster).Include(d=>d.PurchaseOrder).OrderBy(d => d.DateCreated).Skip(skip).Take(take).ToList();
                    return objPurchaseOrderList.Select(x => x.ToModel()).ToList();
                }


            }
        }

        public int GetPoCount(int supplierId, string pOnumber, string startDate, string endDate, bool onPageload)
        {
            using (var db = new InventoryEntities())
            {
                DateTime dtStartDate = Convert.ToDateTime(
                      DateTime.Parse(!string.IsNullOrEmpty(startDate) ? startDate : "1/jan/1901")
                          .ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                DateTime dtEndDate =
                    Convert.ToDateTime(
                        DateTime.Parse(!string.IsNullOrEmpty(startDate) ? startDate : "1/jan/2101")
                            .ToString("MM/dd/yyyy", CultureInfo.InvariantCulture));
                if (onPageload)
                {
                    return db.AdvanceShippings.Count(x => x.Status == 1
                                                         && DbFunctions.TruncateTime(x.DateCreated) == DbFunctions.TruncateTime(System.DateTime.Now
                                                             ));

                }
                else
                {
                    return db.AdvanceShippings.Count(x => x.Status == 1
                                                         &&
                                                         (supplierId == 0 | x.SupplierID == supplierId)
                                                         &&
                                                         (string.IsNullOrEmpty(pOnumber) ||
                                                          x.PONumber == pOnumber)
                                                         &&
                                                         ((string.IsNullOrEmpty(startDate) ||
                                                           x.PurchaseOrder.PODate >= dtStartDate)
                                                          &&
                                                          (string.IsNullOrEmpty(endDate) ||
                                                            x.PurchaseOrder.PODate <= dtEndDate)
                                                             ));
                }
            }
        }
    }
}