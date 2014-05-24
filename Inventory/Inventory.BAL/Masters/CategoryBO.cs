using Inventory.BAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inventory.BAL
{
    public class Category
    {
        public List<CategoryModel> GetList()
        {
            List<CategoryModel> lstCategory = new List<CategoryModel>();
            lstCategory.Add(new CategoryModel() { Id = 1, Name = "Hair Care" });
            lstCategory.Add(new CategoryModel() { Id = 2, Name = "Body Care" });
            lstCategory.Add(new CategoryModel() { Id = 3, Name = "Skin Care" });
            return lstCategory;
        }
    }
}