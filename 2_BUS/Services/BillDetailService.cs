using _1_DAL.IResponsitory;
using _1_DAL.Models;
using _1_DAL.Responsitory;
using _2_BUS.IServices;
using _2_BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class BillDetailService : IBillDetailService
    {
        public IBillDetailResponsitory _IbillDetailResponsitory;
        public BillDetailService()
        {
            _IbillDetailResponsitory = new BilllDetailResponsitory();
        }

        public string Add(BillDetailView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var billd = new BillDetail()
            {
                Id = obj.Id,
                Pro_Id = obj.Pro_Id,
                Bill_Id = obj.Bill_Id,
                Price = obj.Price,
                Quantity = obj.Quantity,
                MaHDCT = obj.MaHDCT,
                Image = obj.Image,

            };
            if (_IbillDetailResponsitory.Add(billd)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<BillDetailView> Get()
        {
            List<BillDetailView> lst = new List<BillDetailView>();
            lst =
                (
                from a in _IbillDetailResponsitory.GetAll()
                select new BillDetailView()
                {
                    Id = a.Id,
                    Pro_Id = a.Pro_Id,
                    Bill_Id = a.Bill_Id,
                    Price = a.Price,
                    Quantity = a.Quantity,
                    MaHDCT = a.MaHDCT,
                    Image = a.Image,
                }
                ).ToList();
            return lst;
        }

        public string Remove(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (_IbillDetailResponsitory.Remove(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string Update(BillDetailView obj)
        {

            if (obj == null) return "Thêm không thành công!";
            var billd = new BillDetail()
            {
                Id = obj.Id,
                Pro_Id = obj.Pro_Id,
                Bill_Id = obj.Bill_Id,
                Price = obj.Price,
                Quantity = obj.Quantity,
                MaHDCT = obj.MaHDCT,
                Image = obj.Image,

            };
            if (_IbillDetailResponsitory.Update(billd)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }
    }
}
