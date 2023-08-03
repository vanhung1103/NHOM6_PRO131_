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
using Color = _1_DAL.Models.Color;

namespace _2_BUS.Services
{
    public class ColorServices : IColorServices
    {
        IResColor colorres;
        List<Color> colorbus;
        public ColorServices()
        {
            colorres = new ResColor();
            colorbus = new List<Color>();
        }
        public string AddColor(Color color)
        {
            if (colorres.AddCor(color))
            {
                return "Them thanh cong";
            }
            return "Thu lai";
        }

        public string DeleteColor(Guid id)
        {
            if (colorres.DeleteCor(id))
            {
                return "Xoa thanh cong";
            }
            return "Thu lai";
        }

        public Color GetColorID(Guid id)
        {
            return colorres.GetCorID(id);
        }

        public List<Color> GetColors()
        {
            return colorbus = colorres.GetCors().ToList();
        }

        public string UpdateColor(Color color)
        {
            if (colorres.UpdateCor(color))
            {
                return "Sua thanh cong";
            }
            return "Thu lai";
        }
    }
}