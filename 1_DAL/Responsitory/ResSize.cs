using _1_DAL.Data;
using _1_DAL.IResponsitory;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Size = _1_DAL.Models.Size;

namespace _1_DAL.Responsitory
{
    public class ResSize : IResSize
    {
        ShopClothesContext contextsize;
        List<Size> sizes;
        public ResSize()
        {
            contextsize = new ShopClothesContext();
            sizes = new List<Size>();
        }
        public bool AddSiz(Size size)
        {
            contextsize.Sizes.Add(size);
            contextsize.SaveChanges();
            return true;
        }

        public bool DeleteSiz(Guid id)
        {
            var idxoa = contextsize.Sizes.Find(id);
            contextsize.Sizes.Add(idxoa);
            contextsize.SaveChanges();
            return true;
        }

        public Size GetSizeID(Guid id)
        {
            return contextsize.Sizes.Find(id);
        }

        public List<Size> GetSizs()
        {
            return sizes = contextsize.Sizes.ToList();
        }

        public bool UpdateSiz(Size size)
        {
            contextsize.Sizes.Update(size);
            contextsize.SaveChanges();
            return true;
        }
    }
}