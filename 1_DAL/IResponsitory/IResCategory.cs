using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IResCategory
    {
        bool AddCate(Category category);
        bool UpdateCate(Category category);
        bool DeleteCate(Guid id);
        List<Category> GetCates();
        Category GetCateID(Guid id);
    }
}