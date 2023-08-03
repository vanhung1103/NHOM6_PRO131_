using _1_DAL.IResponsitory;
using _1_DAL.Models;
using _1_DAL.Responsitory;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Size = _1_DAL.Models.Size;

namespace _2_BUS.Services
{
    public class SizeServices : ISizeServices
    {
        IResSize sizeres;
        List<Size> sizebus;
        public SizeServices()
        {
            sizeres = new ResSize();
            sizebus = new List<Size>();
        }
        public string AddSize(Size size)
        {
            if (sizeres.AddSiz(size))
            {
                return "Them thanh cong";
            }
            return "Thu lai";
        }

        public string DeleteSize(Guid id)
        {
            if (sizeres.DeleteSiz(id))
            {
                return "Xoa thanh cong";
            }
            return "Thu lai";
        }

        public Size GetSizeID(Guid id)
        {
            return sizeres.GetSizeID(id);
        }

        public List<Size> GetSizes()
        {
            return sizebus = sizeres.GetSizs().ToList();
        }

        public string UpdateSize(Size size)
        {
            if (sizeres.UpdateSiz(size))
            {
                return "Sua thanh cong";
            }
            return "Thu lai";
        }
    }
}