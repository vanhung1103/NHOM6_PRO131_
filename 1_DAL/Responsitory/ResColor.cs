using _1_DAL.Data;
using _1_DAL.IResponsitory;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = _1_DAL.Models.Color;

namespace _1_DAL.Responsitory
{
    public class ResColor : IResColor
    {
        ShopClothesContext contextcor;
        List<Color> colors;
        public ResColor()
        {
            contextcor = new ShopClothesContext();
            colors = new List<Color>();
        }
        public bool AddCor(Color color)
        {
            contextcor.Colors.Add(color);
            contextcor.SaveChanges();
            return true;
        }

        public bool DeleteCor(Guid id)
        {
            var idxoa = contextcor.Colors.Find(id);
            contextcor.Colors.Remove(idxoa);
            contextcor.SaveChanges();
            return true;
        }

        public Color GetCorID(Guid id)
        {
            return contextcor.Colors.Find(id);
        }

        public List<Color> GetCors()
        {
            return colors = contextcor.Colors.ToList();
        }

        public bool UpdateCor(Color color)
        {
            contextcor.Colors.Update(color);
            contextcor.SaveChanges();
            return true;
        }
    }
}