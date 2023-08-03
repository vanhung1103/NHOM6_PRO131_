using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ICategoryServices
    {
        string AddCategory(Category category);
        string UpdateCategory(Category category);
        string DeleteCategory(Guid id);
        List<Category> GetCategories();
        Category GetCategoryID(Guid id);
    }
}