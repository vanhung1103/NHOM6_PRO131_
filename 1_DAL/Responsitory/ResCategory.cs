using _1_DAL.Data;
using _1_DAL.IResponsitory;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Responsitory
{
    public class ResCategory : IResCategory
    {
        ShopClothesContext contextcate;
        List<Category> categories;
        public ResCategory()
        {
            contextcate = new ShopClothesContext();
            categories = new List<Category>();
        }
        public bool AddCate(Category category)
        {
            contextcate.Categories.Add(category);
            contextcate.SaveChanges();
            return true;
        }

        public bool DeleteCate(Guid id)
        {
            var idxoa = contextcate.Categories.Find(id);
            contextcate.Categories.Remove(idxoa);
            contextcate.SaveChanges();
            return true;
        }

        public Category GetCateID(Guid id)
        {
            return contextcate.Categories.Find(id);
        }

        public List<Category> GetCates()
        {
            return categories = contextcate.Categories.ToList();
        }

        public bool UpdateCate(Category category)
        {
            contextcate.Categories.Update(category);
            contextcate.SaveChanges();
            return true;
        }
    }
}