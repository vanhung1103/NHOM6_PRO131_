using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IResSize
    {
        bool AddSiz(Size size);
        bool UpdateSiz(Size size);
        bool DeleteSiz(Guid id);
        List<Size> GetSizs();
        Size GetSizeID(Guid id);
    }
}