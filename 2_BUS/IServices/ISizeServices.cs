using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ISizeServices
    {
        string AddSize(Size size);
        string UpdateSize(Size size);
        string DeleteSize(Guid id);
        List<Size> GetSizes();
        Size GetSizeID(Guid id);
    }
}