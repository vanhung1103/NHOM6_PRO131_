using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = _1_DAL.Models.Color;

namespace _2_BUS.IServices
{
    public interface IColorServices
    {
        string AddColor(Color color);
        string UpdateColor(Color color);
        string DeleteColor(Guid id);
        List<Color> GetColors();
        Color GetColorID(Guid id);
    }
}