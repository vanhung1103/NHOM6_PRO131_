using _1_DAL.IResponsitory;
using _1_DAL.Models;
using _1_DAL.Responsitory;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class CategoryServices : ICategoryServices
    {
        IResCategory categoryres;
        List<Category> categoriebus;
        public CategoryServices()
        {
            categoryres = new ResCategory();
            categoriebus = new List<Category>();
        }
        public string AddCategory(Category category)
        {
            if (categoryres.AddCate(category))
            {
                return "Them thanh cong";
            }
            return "Thu lai";
        }

        public string DeleteCategory(Guid id)
        {
            if (categoryres.DeleteCate(id))
            {
                return "Xoa thanh cong";
            }
            return "Thu lai";
        }

        public List<Category> GetCategories()
        {
            return categoriebus = categoryres.GetCates().ToList();
        }

        public Category GetCategoryID(Guid id)
        {
            return categoryres.GetCateID(id);
        }

        public string UpdateCategory(Category category)
        {
            if (categoryres.UpdateCate(category))
            {
                return "Sua thanh cong";
            }
            return "Thu lai";
        }
    }
}