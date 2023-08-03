using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IResponsitory
{
    public interface IResColor
    {
        bool AddCor(Color color);
        bool UpdateCor(Color color);
        bool DeleteCor(Guid id);
        List<Color> GetCors();
        Color GetCorID(Guid id);
    }
}